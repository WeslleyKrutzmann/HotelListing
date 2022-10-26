namespace HotelListing.API.Models.Hotel
{
    public class HotelDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        public long CountryId { get; set; }
    }
}
