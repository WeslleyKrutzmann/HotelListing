using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                    new Country { Id = 1, Name = "Brazil", ShortName = "BRA" },
                    new Country { Id = 2, Name = "United States of America", ShortName = "USA" }
                );

            modelBuilder.Entity<Hotel>().HasData(
                    new Hotel { Id = 1, Name = "Copacabana Palace", Address = "Av. Atlântica, 1702 - Copacabana, Rio de Janeiro - RJ", Rating = 5.0, CountryId = 1 },
                    new Hotel { Id = 2, Name = "Kaimana Beach Hotel", Address = "2863 Kalākaua Ave, Honolulu, HI", Rating = 4.9, CountryId = 2 }
                );
        }
    }
}
