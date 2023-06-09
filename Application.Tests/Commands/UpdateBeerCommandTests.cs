namespace Application.Tests.Commands
{
    using Beer.Commands.UpdateBeer;
    using Common;
    using Microsoft.EntityFrameworkCore;
    using Xunit;

    public class UpdateBeerCommandTests : TestBase
    {
        [Fact]
        public async Task UpdateBeerAsync_Success()
        {
            var handler = new UpdateBeerCommandHandler(Context, Mapper);
            var name = "Updated beer";
            var country = "Updated country";
            var price = 400;
            var production = "Updated production";
            var percentage = 10;

            await handler.Handle(new UpdateBeerCommand(){
                Id = BeerContextFactory.IdForUpdate,
                Name = name,
                Country = country,
                Price = price,
                Production = production,
                AlcoholPercentage = percentage,
            },
            CancellationToken.None);
            
            Assert.NotNull(
                await Context.Beers.FirstOrDefaultAsync(x=>
                    x.Id == BeerContextFactory.IdForUpdate && x.Name == name,CancellationToken.None));
        }
    }
}
