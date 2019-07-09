using AnonseWeb.Feature;
using AnonseWeb.Feature.Statistic;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.ViewModel;
using AutoMapper;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AnonseWeb.Controllers
{
    public class AdvertisementController : Controller
    {
        private IAdvertisementService advertisementService;
        private NewAdvertisement newAdvertisement;
        private CountVisitor countVisitor;
        private DeleteAdvertisement deleteAdvertisement;
        private EditAdvertisement editAdvertisement;
        public AdvertisementController(IAdvertisementService _advertisementService)
        {
            advertisementService = _advertisementService;
            newAdvertisement = new NewAdvertisement(_advertisementService);
            countVisitor = new CountVisitor(_advertisementService);
            deleteAdvertisement = new DeleteAdvertisement(_advertisementService);
            editAdvertisement = new EditAdvertisement(_advertisementService);
        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return View(newAdvertisement.RebuildModelAdvertisement());
        }
        
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(CreateAdvertisementViewModel model)
        {
            if (ModelState.IsValid)
            {
                newAdvertisement.CreateNewAdvertisement(model, User.Identity.GetUserId());
                return RedirectToAction("UserAdvertisement", "User");
            }

            return View(newAdvertisement.RebuildModelAdvertisement());
        }

        [OutputCache(Duration = 20)]
        public ActionResult Detail(int advertisementId)
        {
            if (advertisementId <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var detail = advertisementService.getAdvertisementId(advertisementId);
            if(detail == null)
            {
                return HttpNotFound();
            }

            countVisitor.IncreaseVisitor(advertisementId);
            return View(Mapper.Map(detail, new DetailAdvertisementViewModel()));
        }

        [HttpGet]
        [Authorize]
        public ActionResult Edit(int advertisementId)
        {
           if (advertisementId <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = advertisementService.getAdvertisementId(advertisementId);
            if (model == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map(model, new EditAdvertisementViewModel()));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Edit(EditAdvertisementViewModel model)
        {
            if (ModelState.IsValid)
            {
                editAdvertisement.Edit(model);
                return RedirectToAction("UserAdvertisement", "User");
            }

            return View();
        }

        public ActionResult Delete(int advertisementId)
        {
            deleteAdvertisement.Delete(advertisementId);
            return RedirectToAction("UserAdvertisement", "User");
        }
    }
}