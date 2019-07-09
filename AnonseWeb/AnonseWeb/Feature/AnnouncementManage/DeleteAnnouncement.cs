using AnonseWeb.Service.AnnouncementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.Feature
{
    public class DeleteAnnouncement
    {
        private IAnnouncementService announcementService;
        public DeleteAnnouncement(IAnnouncementService _announcementService)
        {
            announcementService = _announcementService;
        }

        public void Delete(int AnnouncementId)
        {
            var getAnnouncement = announcementService.getAnnouncementId(AnnouncementId);
            announcementService.DeleteAnnouncement(getAnnouncement);
            announcementService.Save();
        }
    }
}