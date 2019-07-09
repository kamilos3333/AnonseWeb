using AnonseWeb.Service.AnnouncementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.Feature.Statistic
{
    public class CountVisitor
    {
        private IAnnouncementService announcementService;
        public CountVisitor(IAnnouncementService _announcementService)
        {
            announcementService = _announcementService;
        }

        public void IncreaseVisitor(int id)
        {
            var count = announcementService.getAnnouncementId(id).Visitor; 
            announcementService.getAnnouncementId(id).Visitor = ++count;
            announcementService.Save();
        }
    }
}