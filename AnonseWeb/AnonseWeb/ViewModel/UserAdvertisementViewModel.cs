using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.ViewModel
{
    public class UserAdvertisementViewModel
    {
        public UserAdvertisementViewModel(IEnumerable<Advertisement> AdvertisementList)
        {
            this.AdvertisementList = AdvertisementList;
        }

        public IEnumerable<Advertisement> AdvertisementList { get; set; }
    }
}