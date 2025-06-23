using CitiesManager.API.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }

        public virtual DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<City>().HasData(

                new City
                {
                    CityID = Guid.Parse("52F39431-DE72-411B-AC43-64B55FF766A1"),
                    Name = "Dhaka"
                },
                new City
                {
                    CityID = Guid.Parse("873BCF7E-D454-4272-923A-8124ABDA6BA2"),
                    Name = "Mymenshingh"
                }
                );
        }
    }
}
