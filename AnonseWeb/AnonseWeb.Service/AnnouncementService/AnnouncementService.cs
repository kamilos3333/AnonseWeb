using AnonseWeb.Data;
using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonseWeb.Service.AnnouncementService
{
    public class AnnouncementService : IAnnouncementService
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IList<Category> getAllCategory()
        {
            return db.Categories.ToList();
        }

        public IList<City> getAllCity()
        {
            return db.Cities.OrderBy(a => a.CityName).ToList();
        }

        public void InsertAnnouncement(Announcement announcement)
        {
            db.Announcements.Add(announcement);
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
