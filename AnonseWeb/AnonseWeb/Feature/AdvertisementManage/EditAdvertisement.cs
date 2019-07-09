using AnonseWeb.Model;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.ViewModel;

namespace AnonseWeb.Feature
{
    public class EditAdvertisement
    {
        private IAdvertisementService advertisementService;
        public EditAdvertisement(IAdvertisementService _advertisementService)
        {
            advertisementService = _advertisementService;
        }

        public void Edit(EditAdvertisementViewModel model)
        {
            Advertisement getAdv = advertisementService.getAdvertisementId(model.AdvertisementId);
            getAdv.AdvertisementName = model.AdvertisementName;
            getAdv.Description = model.Description;
            getAdv.Cost = model.Cost;
            advertisementService.save();
        }
    }
}