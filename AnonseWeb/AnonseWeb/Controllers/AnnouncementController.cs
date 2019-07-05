using AnonseWeb.Feature;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.ViewModel;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnonseWeb.Controllers
{
    public class AnnouncementController : Controller
    {
        private IAnnouncementService announcementService;
        private NewAnnouncement newAnnouncement;
        public AnnouncementController(IAnnouncementService _announcementService)
        {
            announcementService = _announcementService;
            newAnnouncement = new NewAnnouncement(_announcementService);
        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {

            return View(newAnnouncement.RebuildModel());
        }
        
        [HttpPost]
        [ValidateInput(true)]
        public ActionResult Create(CreateAnnouncementViewModel model)
        {
            if (ModelState.IsValid)
            {
                newAnnouncement.CreateNewAnnouncement(model, User.Identity.GetUserId());
                return RedirectToAction("Index", "Home");
            }

            return View(newAnnouncement.RebuildModel());
        }
    }
}