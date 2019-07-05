using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonseWeb.Service.AnnouncementService
{
    public interface IAnnouncementService
    {
        IList<City> getAllCity();
        IList<Category> getAllCategory();
        void InsertAnnouncement(Announcement announcement);
        void InsertFile(File file);
        void Save();
    }
}
