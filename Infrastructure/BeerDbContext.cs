namespace Infrastructure
{
    using Application.Interfaces;
    using Domain;
    using Microsoft.EntityFrameworkCore;

    public class BeerDbContext : DbContext, IBeerDbContext
    {
        public BeerDbContext(DbContextOptions<BeerDbContext> options) : base(options)
        {}
        public DbSet<Beer> Beers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beer>().HasData
            (
                new Beer()
                {
                    AlcoholPercentage = 4.5f, 
                    Country = "Ukraine", 
                    Name = "Chernihivske", 
                    Price = 25,
                    Id = Guid.NewGuid(),
                    Production = "Svatove"
                }
            );
        }
    }
}
