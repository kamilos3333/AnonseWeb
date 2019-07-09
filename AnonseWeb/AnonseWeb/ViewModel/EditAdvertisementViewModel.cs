using System.ComponentModel.DataAnnotations;

namespace AnonseWeb.ViewModel
{
    public class EditAdvertisementViewModel
    {
        public int AdvertisementId { get; set; }

        [Required]
        [Display(Name = "Tytuł ogloszenia")]
        public string AdvertisementName { get; set; }

        [Required]
        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Koszt")]
        [Range(0, 10000)]
        public int Cost { get; set; }
    }
}