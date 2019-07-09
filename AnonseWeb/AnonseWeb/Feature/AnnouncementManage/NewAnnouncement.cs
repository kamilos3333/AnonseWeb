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
    public class NewAnnouncement
    {
        private IAnnouncementService announcementService;
        private NewImage newImage;
        public NewAnnouncement(IAnnouncementService _announcementService)
        {
            announcementService = _announcementService;
            newImage = new NewImage(_announcementService);
        }

        public void CreateNewAnnouncement(CreateAnnouncementViewModel model, string UserId)
        {
            Announcement announcement = new Announcement
            {
                AnnouncementName = model.AnnouncementName,
                Description = model.AnnouncementDescription,
                Cost = model.Cost,
                CityId = model.CityId,
                CategoryId = model.CategoryId,
                DateBegin = DateTime.Now,
                DateEnd = model.DateEnd,
                Status = Status.Aktywny.ToString(),
                Visitor = 0,
                Id = UserId
            };

            announcementService.InsertAnnouncement(announcement);
            announcementService.Save();
            newImage.CreateNewImage(model.ImageUpload, announcement.AnnouncementId);
        }

        public CreateAnnouncementViewModel RebuildModelAnnouncement()
        {
            var announcementModel = new CreateAnnouncementViewModel();
            announcementModel.CityList = announcementService.getAllCity();
            announcementModel.CategoryList = announcementService.getAllCategory();

            return announcementModel;
        }

    }
}