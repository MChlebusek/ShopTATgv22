using System.ComponentModel.DataAnnotations;

namespace Shop.Models.AccuWeather
{
    public class SearchCityViewModel
    {
        [Required(ErrorMessage = "You must enter a city name!")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Oly text allowed")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Enter a city name")]
        [Display(Name = "City Name")]

        public string CityName { get; set; }


    }

}
