using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnonseWeb.ViewModel
{
    public class SearchViewModel
    {
        [Display(Name = "Nazwa")]
        public string SearchValueName { get; set; }

        public IList<City> CityList { get; set; }

        [Display(Name = "Miasto")]
        public int CityId { get; set; }

        [Range(0,100)]
        [Display(Name = "Odległość")]
        public int Distance { get; set; }

        public IQueryable<Advertisement> AdvertisementList { get; set; }
    }
}