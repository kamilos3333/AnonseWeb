using AnonseWeb.Model;
using System.Collections.Generic;
using System.Linq;

namespace AnonseWeb.Service.SearchService
{
    public interface ISearchService
    {
        IQueryable<Announcement> SearchAnnouncement();
        City GetCityId(int CityId);
    }
}
