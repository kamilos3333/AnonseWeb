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
        private IAdvertisementService advertisementService;
        public SearchFeature(ISearchService _searchService, IAdvertisementService _advertisementService)
        {
            searchService = _searchService;
            advertisementService = _advertisementService;
        }

        public IQueryable<Advertisement> SearchAdvertisement(int cityId, string searchValueName, int distance)
        {
            var query = searchService.searchAdvertisement();
            query = SearchByCity(cityId, query);
            query = SearchByCordinate(distance, cityId, query);
            query = SearchByName(searchValueName, query);
            
            return query;
        }

        private IQueryable<Advertisement> SearchByName(string searchValueName, IQueryable<Advertisement> query)
        {
            if (searchValueName != null)
            {
                query = query.Where(a => a.AdvertisementName.Contains(searchValueName));
            }

            return query;
        }

        private IQueryable<Advertisement> SearchByCity(int cityId, IQueryable<Advertisement> query)
        {
            if (cityId > 0)
            {
                query = query.Where(a => a.CityId == cityId);
            }

            return query;
        }

        private IQueryable<Advertisement> SearchByCordinate(int distance, int cityId, IQueryable<Advertisement> query)
        {
            if (distance > 0 && cityId > 0)
            {
                query = searchService.searchAdvertisement();
                var city = GetCityById(cityId);
                var cord = new CordCalculation(city, distance);

                query = query.Where(a => a.cities.lat > cord.MinLat
                && a.cities.lat < cord.MaxLat
                && a.cities.lon > cord.MinLon
                && a.cities.lon < cord.MaxLon);
            }

            return query;
        }

        private City GetCityById(int CityId)
        {
            return searchService.getCityId(CityId);
        }

        public void RebuildModelSearch(SearchViewModel searchModel)
        {
            searchModel.CityList = advertisementService.getAllCity();
        }

    }
}