namespace Application.Beer.Commands.DeleteBeer
{
    using Interfaces;
    using MediatR;

    public class DeleteBeerCommandHandler : IRequestHandler<DeleteBeerCommand, Unit>
    {
        private readonly IBeerDbContext _db;
        
        public DeleteBeerCommandHandler(IBeerDbContext db) => _db = db;
        
        public async Task<Unit> Handle(DeleteBeerCommand request, CancellationToken cancellationToken)
        {
            var beer = await _db.Beers.FindAsync(new object?[] { request.Id, cancellationToken }, cancellationToken);
            if(beer != null)
                _db.Beers.Remove(beer);

            return new Unit();
        }
    }
}
