namespace Application.Tests.Commands
{
    using Beer.Commands.CreateBeer;
    using Common;
    using Microsoft.EntityFrameworkCore;
    using Xunit;

    public class CreateBeerCommandTests : TestBase
    {
        [Fact]
        public async Task CreateBeerAsync_Success()
        {
            var handler = new CreateBeerCommandHandler(Context, Mapper);
            var name = "xxx";
            var production = "xxx";
            var country = "xxx";
            var percentage = 3.2f;
            var price = 300;

            var id = await handler.Handle(new CreateBeerCommand(){
                Name = name,
                Production = production,
                Country = country,
                AlcoholPercentage = percentage,
                Price = price,
            }, CancellationToken.None);
            
            Assert.NotNull(
                await Context.Beers.SingleOrDefaultAsync(beer => beer.Id == id &&
                    beer.Name == name && beer.Country == country &&
                    Math.Abs(beer.AlcoholPercentage - percentage) < 0.000001 &&
                    beer.Price == price, CancellationToken.None));
        }
    }
}
