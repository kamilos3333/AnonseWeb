using AnonseWeb.Model;
using AnonseWeb.Models;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.Service.SearchService;
using AnonseWeb.ViewModel;
using System.Linq;

namespace AnonseWeb.Feature.Search
{
    public class SearchFeature
    {
        private ISearchService searchService;
        private IAnnouncementService announcementService;
        public SearchFeature(ISearchService _searchService, IAnnouncementService _announcementService)
        {
            searchService = _searchService;
            announcementService = _announcementService;
        }

        public IQueryable<Announcement> SearchAnnouncement(int CityId, string SearchValueName, int Distance)
        {
            var query = searchService.SearchAnnouncement();
            query = SearchByCity(CityId, query);
            query = SearchByCordinate(Distance, CityId, query);
            query = SearchByName(SearchValueName, query);
            
            return query;
        }

        private IQueryable<Announcement> SearchByName(string SearchValueName, IQueryable<Announcement> query)
        {
            if (SearchValueName != null)
            {
                query = query.Where(a => a.AnnouncementName.Contains(SearchValueName));
            }

            return query;
        }

        private IQueryable<Announcement> SearchByCity(int CityId, IQueryable<Announcement> query)
        {
            if (CityId > 0)
            {
                query = query.Where(a => a.CityId == CityId);
            }

            return query;
        }

        private IQueryable<Announcement> SearchByCordinate(int Distance, int CityId, IQueryable<Announcement> query)
        {
            if (Distance > 0 && CityId > 0)
            {
                query = searchService.SearchAnnouncement();
                var city = GetCityById(CityId);
                var cord = new CordCalculation(city, Distance);

                query = query.Where(a => a.cities.lat > cord.MinLat
                && a.cities.lat < cord.MaxLat
                && a.cities.lon > cord.MinLon
                && a.cities.lon < cord.MaxLon);
            }

            return query;
        }

        private City GetCityById(int CityId)
        {
            return searchService.GetCityId(CityId);
        }

        public void RebuildModelSearch(SearchViewModel searchModel)
        {
            searchModel.CityList = announcementService.getAllCity();
        }

    }
}