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
    public class AdvertisementService : IAdvertisementService
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public IList<Advertisement> getAllAdvertisement()
        {
            return db.Advertisements.Include(c => c.files).ToList();
        }
        
        public IList<Category> getAllCategory()
        {
            return db.Categories.ToList();
        }

        public IList<City> getAllCity()
        {
            return db.Cities.OrderBy(a => a.CityName).ToList();
        }

        public IList<Advertisement> advertisementForClient()
        {
            return db.Advertisements.Include(c => c.files).OrderByDescending(a => a.DateBegin).Where(a => a.DateEnd >= DateTime.Now).ToList();
        }

        public void insertAdvertisement(Advertisement advertisement)
        {
            db.Advertisements.Add(advertisement);
        }

        public void insertFile(File file)
        {
            db.Files.Add(file);
        }

        public void save()
        {
            db.SaveChanges();
        }

        public Advertisement getAdvertisementId(int advertisementId)
        {
            return db.Advertisements.Include(c => c.files).Include(a => a.users).FirstOrDefault(a => a.AdvertisementId == advertisementId);
        }

        public IList<Advertisement> getUserAdvertisement(string id)
        {
            return db.Advertisements.Where(a => a.Id == id).ToList();
        }

        public void deleteAdvertisement(Advertisement advertisement)
        {
            db.Advertisements.Remove(advertisement);
        }

        public void editAdvertisement(Advertisement advertisement)
        {
            db.Entry(advertisement).State = EntityState.Modified;
        }
    }
}
