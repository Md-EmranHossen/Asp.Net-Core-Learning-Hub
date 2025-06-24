using System.ComponentModel.DataAnnotations;

namespace CitiesManager.API.Models
{
    public class City
    {
        [Key]
        public Guid CityID { get; set; }
        public string? Name { get; set; }


    }
}
