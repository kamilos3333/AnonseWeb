using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.ViewModel
{
    public class UserAnnouncementViewModel
    {
        public UserAnnouncementViewModel(IEnumerable<Announcement> AnnouncementList)
        {
            this.AnnouncementList = AnnouncementList;
        }

        public IEnumerable<Announcement> AnnouncementList { get; set; }
    }
}