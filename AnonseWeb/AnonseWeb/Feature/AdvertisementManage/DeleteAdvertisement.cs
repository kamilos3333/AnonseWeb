using AnonseWeb.Service.AnnouncementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.Feature
{
    public class DeleteAdvertisement
    {
        private IAdvertisementService advertisementService;
        public DeleteAdvertisement(IAdvertisementService _advertisementService)
        {
            advertisementService = _advertisementService;
        }

        public void Delete(int advertisementId)
        {
            var getAdvertisement = advertisementService.getAdvertisementId(advertisementId);
            advertisementService.deleteAdvertisement(getAdvertisement);
            advertisementService.save();
        }
    }
}