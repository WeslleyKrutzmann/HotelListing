using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country
{
    public class CountryDto : BaseCountryDto
    {
        public long Id { get; set; }
        public List<HotelDto> Hotels {get;set;}
    }
}
