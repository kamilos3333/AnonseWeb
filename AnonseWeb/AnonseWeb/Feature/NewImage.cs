using AnonseWeb.Manager;
using AnonseWeb.Model;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.Feature
{
    public class NewImage
    {
        private IAdvertisementService advertisementService;
        public NewImage(IAdvertisementService _advertisementService)
        {
            advertisementService = _advertisementService;
        }

        public void CreateNewImage(HttpPostedFileBase image, int advertisementId)
        {
            var fileName = ImageUpload.InsertImage(image);

            InsertImageToDatabase(advertisementId, fileName);
        }

        private void InsertImageToDatabase(int advertisementId, string fileName)
        {
            File file = new File
            {
                AdvertisementId = advertisementId,
                FileName = fileName
            };

            advertisementService.insertFile(file);
            advertisementService.save();
        }
    }
}