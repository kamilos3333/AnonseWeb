using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnonseWeb.Models
{
    public class CordCalculation
    {
        public double MinLat { get; set; }
        public double MaxLat { get; set; }

        public double MinLon { get; set; }
        public double MaxLon { get; set; }

        public CordCalculation(City city, int range)
        {
            MinLat = city.lat - (range / 110.57);
            MaxLat = city.lat + (range / 110.57);

            MinLon = city.lon - (range / 110.57);
            MaxLon = city.lon + (range / 110.57);
        }
    }
}