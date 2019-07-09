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
        IList<Announcement> GetAllAnnouncement();
        IList<Announcement> AnnouncementForClient();
        IList<Announcement> getUserAnnouncement(string id);
        Announcement getAnnouncementId(int Id);
        void DeleteAnnouncement(Announcement announcement);
        void EditAnnouncement(Announcement announcement);
        void InsertAnnouncement(Announcement announcement);
        void InsertFile(File file);
        void Save();
    }
}
