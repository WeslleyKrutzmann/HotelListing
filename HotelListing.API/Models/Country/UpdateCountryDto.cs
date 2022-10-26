using Microsoft.Build.Framework;

namespace HotelListing.API.Models.Country
{
    public class UpdateCountryDto: BaseCountryDto
    {
        public long Id { get; set; }
    }
}
