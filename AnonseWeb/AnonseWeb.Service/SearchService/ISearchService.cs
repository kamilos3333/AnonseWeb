using AnonseWeb.Model;
using System.Collections.Generic;
using System.Linq;

namespace AnonseWeb.Service.SearchService
{
    public interface ISearchService
    {
        IQueryable<Advertisement> searchAdvertisement();
        City getCityId(int cityId);
    }
}
