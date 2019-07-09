﻿using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.ViewModel
{
    public class HomeViewModel
    {
        public HomeViewModel(IEnumerable<Advertisement> advertisementList)
        {
            AdvertisementList = advertisementList;
        }

        public IEnumerable<Advertisement> AdvertisementList { get; set; }
    }
}