using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnonseWeb.Enums;
using AnonseWeb.Model;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.ViewModel;

namespace AnonseWeb.Feature
{
    public class NewAdvertisement
    {
        private IAdvertisementService advertisementService;
        private NewImage newImage;
        public NewAdvertisement(IAdvertisementService _advertisementService)
        {
            advertisementService = _advertisementService;
            newImage = new NewImage(_advertisementService);
        }

        public void CreateNewAdvertisement(CreateAdvertisementViewModel model, string UserId)
        {
            Advertisement advertisement = new Advertisement
            {
                AdvertisementName = model.AdvertisementName,
                Description = model.AdvertisementDescription,
                Cost = model.Cost,
                CityId = model.CityId,
                CategoryId = model.CategoryId,
                DateBegin = DateTime.Now,
                DateEnd = model.DateEnd,
                Status = Status.Aktywny.ToString(),
                Visitor = 0,
                Id = UserId
            };

            advertisementService.insertAdvertisement(advertisement);
            advertisementService.save();
            newImage.CreateNewImage(model.ImageUpload, advertisement.AdvertisementId);
        }

        public CreateAdvertisementViewModel RebuildModelAdvertisement()
        {
            var advertisementModel = new CreateAdvertisementViewModel();
            advertisementModel.CityList = advertisementService.getAllCity();
            advertisementModel.CategoryList = advertisementService.getAllCategory();

            return advertisementModel;
        }

    }
}