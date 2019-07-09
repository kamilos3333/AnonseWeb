using AnonseWeb.Feature.Search;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.Service.SearchService;
using AnonseWeb.ViewModel;
using System.Web.Mvc;

namespace AnonseWeb.Controllers
{
    public class HomeController : Controller
    {
        private IAdvertisementService advertisementService;
        private ISearchService searchService;
        private SearchFeature searchFeature; 
        public HomeController(IAdvertisementService _advertisementService, ISearchService _searchService)
        {
            searchFeature = new SearchFeature(_searchService, _advertisementService);
            advertisementService = _advertisementService;
            searchService = _searchService;
        }
        
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel(advertisementService.advertisementForClient());
            return View(model);
        }

        [ValidateInput(false)]
        public ActionResult AdvertisementSearch(SearchViewModel searchModel)
        {
            searchFeature.RebuildModelSearch(searchModel);

            if (ModelState.IsValid)
            {
                searchModel.AdvertisementList = searchFeature.SearchAdvertisement(searchModel.CityId, searchModel.SearchValueName, searchModel.Distance);
                searchFeature.RebuildModelSearch(searchModel);
                return View(searchModel);
            }
            
            return View(searchModel);
        }
        
    }
}