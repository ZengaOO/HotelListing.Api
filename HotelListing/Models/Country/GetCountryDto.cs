using HotelListing.API.Data;
using HotelListing.API.Models.Hotel;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelListing.API.Models.Country
{
    public class GetCountryDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
    }

    public class CountryDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        public List<HotelDto> Hotels { get; set; }
    }
       
}
