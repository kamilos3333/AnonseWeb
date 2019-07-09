using AnonseWeb.Data;
using AnonseWeb.Model;
using System.Collections.Generic;
using System.Linq;

namespace AnonseWeb.Service.SearchService
{
    public class SearchService : ISearchService
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public City getCityId(int cityId)
        {
            return db.Cities.FirstOrDefault(a => a.CityId == cityId);
        }

        public IQueryable<Advertisement> searchAdvertisement()
        {
           return db.Advertisements.Include("Cities").AsQueryable();
        }
        
    }
    
}
