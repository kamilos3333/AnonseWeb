using AnonseWeb.Model;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.Feature
{
    public class EditAnnouncement
    {
        private IAnnouncementService announcementService;
        public EditAnnouncement(IAnnouncementService _announcementService)
        {
            announcementService = _announcementService;
        }

        public void Edit(EditAnnouncementViewModel model)
        {
            Announcement getAnno = announcementService.getAnnouncementId(model.AnnouncementId);
            getAnno.AnnouncementName = model.AnnouncementName;
            getAnno.Description = model.Description;
            getAnno.Cost = model.Cost;
            announcementService.Save();
        }
    }
}