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
    public class AnnouncementController : Controller
    {
        private IAnnouncementService announcementService;
        private NewAnnouncement newAnnouncement;
        private CountVisitor countVisitor;
        private DeleteAnnouncement deleteAnnouncement;
        private EditAnnouncement editAnnouncement;
        public AnnouncementController(IAnnouncementService _announcementService)
        {
            announcementService = _announcementService;
            newAnnouncement = new NewAnnouncement(_announcementService);
            countVisitor = new CountVisitor(_announcementService);
            deleteAnnouncement = new DeleteAnnouncement(_announcementService);
            editAnnouncement = new EditAnnouncement(_announcementService);
        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return View(newAnnouncement.RebuildModelAnnouncement());
        }
        
        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Create(CreateAnnouncementViewModel model)
        {
            if (ModelState.IsValid)
            {
                newAnnouncement.CreateNewAnnouncement(model, User.Identity.GetUserId());
                return RedirectToAction("UserAnnouncement", "User");
            }

            return View(newAnnouncement.RebuildModelAnnouncement());
        }

        [OutputCache(Duration = 20)]
        public ActionResult Detail(int announcementId)
        {
            if (announcementId <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var detail = announcementService.getAnnouncementId(announcementId);
            if(detail == null)
            {
                return HttpNotFound();
            }
            countVisitor.IncreaseVisitor(announcementId);
            return View(Mapper.Map(detail, new DetailAnnouncementViewModel()));
        }

        [HttpGet]
        public ActionResult Edit(int announcementId)
        {
           if (announcementId <= 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var model = announcementService.getAnnouncementId(announcementId);
            if (model == null)
            {
                return HttpNotFound();
            }

            return View(Mapper.Map(model, new EditAnnouncementViewModel()));
        }

        [HttpPost]
        public ActionResult Edit(EditAnnouncementViewModel model)
        {
            if (ModelState.IsValid)
            {
                editAnnouncement.Edit(model);
                return RedirectToAction("UserAnnouncement", "User");
            }

            return View();
        }

        public ActionResult Delete(int announcementId)
        {
            deleteAnnouncement.Delete(announcementId);
            return RedirectToAction("UserAnnouncement", "User");
        }
    }
}