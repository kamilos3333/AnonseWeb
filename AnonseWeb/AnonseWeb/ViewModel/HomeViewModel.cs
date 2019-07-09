using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.ViewModel
{
    public class HomeViewModel
    {
        public HomeViewModel(IEnumerable<Announcement> announcementList)
        {
            AnnouncementList = announcementList;
        }

        public IEnumerable<Announcement> AnnouncementList { get; set; }
    }
}