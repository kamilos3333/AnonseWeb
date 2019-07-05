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
        private IAnnouncementService announcementService;
        public NewImage(IAnnouncementService _announcementService)
        {
            announcementService = _announcementService;
        }

        public void CreateNewImage(HttpPostedFileBase image, int AnnouncementId)
        {
            var fileName = ImageUpload.InsertImage(image);
            
            File file = new File
            {
                AnnouncementId = AnnouncementId,
                FileName = fileName
            };

            announcementService.InsertFile(file);
            announcementService.Save();
        }
    }
}