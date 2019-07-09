using AnonseWeb.Data;
using AnonseWeb.Model;
using System.Collections.Generic;
using System.Linq;

namespace AnonseWeb.Service.SearchService
{
    public class SearchService : ISearchService
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public City GetCityId(int CityId)
        {
            return db.Cities.FirstOrDefault(a => a.CityId == CityId);
        }

        public IQueryable<Announcement>SearchAnnouncement()
        {
           return db.Announcements.Include("Cities").AsQueryable();
        }
        
    }
    
}
