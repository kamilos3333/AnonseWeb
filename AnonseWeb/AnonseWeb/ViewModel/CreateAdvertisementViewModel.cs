using AnonseWeb.Model;
using PublicTransportGallery.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnonseWeb.ViewModel
{
    public class CreateAdvertisementViewModel
    {
        [Required]
        [Display(Name = "Tytuł ogloszenia")]
        public string AdvertisementName { get; set; }


        [Display(Name = "Opis")]
        public string AdvertisementDescription { get; set; }
        
        [Display(Name = "Data zakończenia ogłoszenia")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateEnd { get; set; }

        public IList<Category> CategoryList { get; set; }

        [Display(Name = "Kategoria")]
        public int CategoryId { get; set; }

        public IList<City> CityList { get; set; }

        [Display(Name = "Miasto")]
        public int CityId { get; set; }

        [Required]
        [Display(Name = "Koszt")]
        [Range(0,10000)]
        public int Cost { get; set; }

        [Required]
        [Display(Name = "Zdjęcie")]
        [DataType(DataType.Upload)]
        [File(AllowedFileExtensions = new string[] { ".jpg", ".png" }, MaxContentLength = 1024 * 1024 * 2, ErrorMessage = "Niepoprawny format pliku")]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}