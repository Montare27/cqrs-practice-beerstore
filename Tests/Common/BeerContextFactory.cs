namespace Tests.Common
{
    using Domain;
    using Infrastructure;
    using Microsoft.EntityFrameworkCore;

    public static class BeerContextFactory
    {
        public enum IdForCreate
        {
            Beer1 = 213,
            Beer2 = 213,
            Beer3 = 213,
            Beer4 = 213,
            Beer5 = 213,
        }
        
        public static Guid BeerIdUpdate = Guid.NewGuid();
        public static Guid BeerIdDelete = Guid.NewGuid();

        public static BeerDbContext Create()
        {
            var options = new DbContextOptionsBuilder<BeerDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new BeerDbContext(options);
            context.Database.EnsureCreated();
            context.Beers.AddRange(
                new Beer(){
                    Id = Guid.NewGuid(),
                    Name = "Beer1",
                    Production = "Production1",
                    Country = "Country1",
                    AlcoholPercentage = 0,
                    Price = 0,
                },   
                new Beer(){
                    Id = Guid.NewGuid(),
                    Name = "Beer2",
                    Production = "Production2",
                    Country = "Country2",
                    AlcoholPercentage = 0,
                    Price = 0,
                },    
                new Beer(){
                    Id = Guid.NewGuid(),
                    Name = "Beer3",
                    Production = "Production3",
                    Country = "Country3",
                    AlcoholPercentage = 0,
                    Price = 0,
                },
                new Beer(){
                    Id = Guid.NewGuid(),
                    Name = "Beer4",
                    Production = "Production4",
                    Country = "Country4",
                    AlcoholPercentage = 0,
                    Price = 0,
                },    
                new Beer(){
                    Id = Guid.NewGuid(),
                    Name = "Beer5",
                    Production = "Production5",
                    Country = "Country5",
                    AlcoholPercentage = 0,
                    Price = 0,
                }
            );

            context.SaveChanges();
            return context;
        }

        public static void Destroy(BeerDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Dispose();
        }
        
    }
}
