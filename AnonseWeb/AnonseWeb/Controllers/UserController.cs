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
    public class UserController : Controller
    {
        private IAnnouncementService announcementService;
        public UserController(IAnnouncementService _announcementService)
        {
            announcementService = _announcementService;
        }

        // GET: User
        public ActionResult UserAnnouncement()
        {
            var getUserAnnouncement = announcementService.getUserAnnouncement(User.Identity.GetUserId());
            var model = new UserAnnouncementViewModel(getUserAnnouncement);
            return View(model);
        }
    }
}