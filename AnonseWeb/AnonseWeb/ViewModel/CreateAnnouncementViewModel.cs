using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnonseWeb.ViewModel
{
    public class CreateAnnouncementViewModel
    {
        [Display(Name = "Tytuł ogloszenia")]
        [Required]
        public string AnnouncementName { get; set; }

        [Display(Name = "Opis")]
        [Required]
        public string AnnouncementDescription { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateBegin { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }

        public IList<Category> CategoryList { get; set; }
        public int CategoryId { get; set; }

        public IList<City> CityList { get; set; }
        public int CityId { get; set; }

        [DataType(DataType.Upload)]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}