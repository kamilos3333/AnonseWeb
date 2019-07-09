using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonseWeb.Model
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string CityName { get; set; }
        
        public double lat { get; set; }
        public double lon { get; set; }

        public virtual ICollection<Advertisement> advertisements { get; set; }
    }
}
