using AnonseWeb.Service.AnnouncementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.Feature.Statistic
{
    public class CountVisitor
    {
        private IAdvertisementService advertisementService;
        public CountVisitor(IAdvertisementService _advertisementService)
        {
            advertisementService = _advertisementService;
        }

        public void IncreaseVisitor(int id)
        {
            var count = advertisementService.getAdvertisementId(id).Visitor;
            advertisementService.getAdvertisementId(id).Visitor = ++count;
            advertisementService.save();
        }
    }
}