using AnonseWeb.Enums;
using AnonseWeb.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnonseWeb.ViewModel
{
    public class EditAnnouncementViewModel
    {
        public int AnnouncementId { get; set; }

        [Required]
        [Display(Name = "Tytuł ogloszenia")]
        public string AnnouncementName { get; set; }

        [Required]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Koszt")]
        [Range(0, 10000)]
        public int Cost { get; set; }
    }
}