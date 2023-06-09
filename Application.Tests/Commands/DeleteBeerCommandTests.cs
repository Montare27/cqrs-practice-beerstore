namespace Application.Tests.Commands
{
    using Beer.Commands.DeleteBeer;
    using Common;
    using Microsoft.EntityFrameworkCore;
    using Xunit;

    public class DeleteBeerCommandTests : TestBase
    {
        [Fact]
        public async void DeleteBeerAsync_Test()
        {
            var handler = new DeleteBeerCommandHandler(Context);
            
            await handler.Handle(new DeleteBeerCommand(){
                Id = BeerContextFactory.IdForDelete
            },
            CancellationToken.None);
            
            Assert.Null(await Context.Beers.FirstOrDefaultAsync(x=>
                x.Id == BeerContextFactory.IdForDelete));
        }
    }
}
