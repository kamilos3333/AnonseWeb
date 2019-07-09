using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnonseWeb.ViewModel
{
    public class DetailAdvertisementViewModel
    {
        [Display(Name = "Tytuł ogłoszenia")]
        public string AdvertisementName { get; set; }

        [Display(Name = "Opis")]
        public string AdvertisementDesc { get; set; }

        [Display(Name = "Data rozpoczęcia ogłoszenia")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateBegin { get; set; }

        [Display(Name = "Data zakończenia ogłoszenia")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DateEnd { get; set; }

        [Display(Name = "Liczba odwiedzających")]
        public int Visitor { get; set; }

        [Display(Name = "Kategoria")]
        public string CategoryName { get; set; }

        [Display(Name = "Miasto")]
        public string CityName { get; set; }

        [Display(Name = "Koszt")]
        public int Cost { get; set; }

        [Display(Name = "Zdjęcie")]
        public string Photo { get; set; }

        [Display(Name = "Adres email")]
        public string Email { get; set; }

        [Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }
    }
}