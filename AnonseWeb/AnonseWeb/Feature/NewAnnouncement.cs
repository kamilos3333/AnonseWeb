using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnonseWeb.Model;
using AnonseWeb.Service.AnnouncementService;
using AnonseWeb.ViewModel;

namespace AnonseWeb.Feature
{
    public class NewAnnouncement
    {
        private IAnnouncementService announcementService;
        public NewAnnouncement(IAnnouncementService _announcementService)
        {
            announcementService = _announcementService;
        }

        public void CreateNewAnnouncement(CreateAnnouncementViewModel model, string UserId)
        {
            Announcement announcement = new Announcement
            {
                AnnouncementName = model.AnnouncementName,
                Description = model.AnnouncementDescription,
                CityId = model.CityId,
                CategoryId = model.CategoryId,
                DateBegin = DateTime.Now,
                DateEnd = DateTime.Now,
                Status = "Aktywny",
                Visitor = 0,
                Id = UserId
            };

            announcementService.InsertAnnouncement(announcement);
            announcementService.Save();
        }

        public CreateAnnouncementViewModel RebuildModel()
        {
            CreateAnnouncementViewModel announcementModel = new CreateAnnouncementViewModel();
            announcementModel.CityList = announcementService.getAllCity();
            announcementModel.CategoryList = announcementService.getAllCategory();
            return announcementModel;
        }
        
    }
}