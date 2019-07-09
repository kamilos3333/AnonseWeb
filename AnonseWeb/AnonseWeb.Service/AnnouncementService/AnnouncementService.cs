using AnonseWeb.Data;
using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AnonseWeb.Service.AnnouncementService
{
    public class AnnouncementService : IAnnouncementService
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IList<Announcement> GetAllAnnouncement()
        {
            return db.Announcements.Include(c => c.files).ToList();
        }
        
        public IList<Category> getAllCategory()
        {
            return db.Categories.ToList();
        }

        public IList<City> getAllCity()
        {
            return db.Cities.OrderBy(a => a.CityName).ToList();
        }

        public IList<Announcement> AnnouncementForClient()
        {
            return db.Announcements.Include(c => c.files).OrderByDescending(a => a.DateBegin).Where(a => a.DateEnd >= DateTime.Now).ToList();
        }

        public void InsertAnnouncement(Announcement announcement)
        {
            db.Announcements.Add(announcement);
        }

        public void InsertFile(File file)
        {
            db.Files.Add(file);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public Announcement getAnnouncementId(int AnnouncementId)
        {
            return db.Announcements.Include(c => c.files).Include(a => a.users).FirstOrDefault(a => a.AnnouncementId == AnnouncementId);
        }

        public IList<Announcement> getUserAnnouncement(string id)
        {
            return db.Announcements.Where(a => a.Id == id).ToList();
        }

        public void DeleteAnnouncement(Announcement announcement)
        {
            db.Announcements.Remove(announcement);
        }

        public void EditAnnouncement(Announcement announcement)
        {
            db.Entry(announcement).State = EntityState.Modified;
        }
    }
}
