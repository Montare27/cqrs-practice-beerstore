namespace Application.Tests.Common
{
    using Domain;
    using Infrastructure;
    using Microsoft.EntityFrameworkCore;

    public static class BeerContextFactory
    {
        public static Guid IdForUpdate = Guid.Parse("222b23bc-bfad-4a28-93f7-51ea433bc9a4");
        public static Guid IdForDelete = Guid.Parse("812c100f-b5e7-4ad5-abc9-eb068af7180b");
        
        public static BeerDbContext Create()
        {
            var options = new DbContextOptionsBuilder<BeerDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            var context = new BeerDbContext(options);
            context.Database.EnsureCreated();
            context.Beers.AddRange(
                new Beer(){
                    Id = IdForUpdate,
                    Name = "Beer1",
                    Production = "Prod1",
                    Country = "Country1",
                    AlcoholPercentage = 0,
                    Price = 0,
                },new Beer(){
                    Id = IdForDelete,
                    Name = "Beer2",
                    Production = "Prod2",
                    Country = "Country2",
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
