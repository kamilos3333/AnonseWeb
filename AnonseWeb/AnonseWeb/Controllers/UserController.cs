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
        private IAdvertisementService advertisementService;
        public UserController(IAdvertisementService _advertisementService)
        {
            advertisementService = _advertisementService;
        }

        // GET: User
        [Authorize]
        public ActionResult UserAdvertisement()
        {
            var getUserAnnouncement = advertisementService.getUserAdvertisement(User.Identity.GetUserId());
            var model = new UserAdvertisementViewModel(getUserAnnouncement);
            return View(model);
        }
    }
}