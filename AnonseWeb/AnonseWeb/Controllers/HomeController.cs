using AnonseWeb.Feature.Search;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.Service.SearchService;
using AnonseWeb.ViewModel;
using System.Web.Mvc;

namespace AnonseWeb.Controllers
{
    public class HomeController : Controller
    {
        private IAnnouncementService announcementService;
        private ISearchService searchService;
        SearchFeature searchFeature; 
        public HomeController(IAnnouncementService _announcementService, ISearchService _searchService)
        {
            searchFeature = new SearchFeature(_searchService, _announcementService);
            announcementService = _announcementService;
            searchService = _searchService;
        }
        
        public ActionResult Index()
        {
            HomeViewModel model = new HomeViewModel(announcementService.AnnouncementForClient());
            return View(model);
        }
        
        public ActionResult AnnouncementSearch(SearchViewModel searchModel)
        {
            searchFeature.RebuildModelSearch(searchModel);

            if (ModelState.IsValid)
            {
                searchModel.AnnouncementList = searchFeature.SearchAnnouncement(searchModel.CityId, searchModel.SearchValueName, searchModel.Distance);
                searchFeature.RebuildModelSearch(searchModel);
                return View(searchModel);
            }
            
            return View(searchModel);
        }
        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}