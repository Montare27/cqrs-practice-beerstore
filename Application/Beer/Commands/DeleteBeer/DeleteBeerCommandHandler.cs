namespace Application.Beer.Commands.DeleteBeer
{
    using Interfaces;
    using MediatR;
    using Microsoft.EntityFrameworkCore;

    public class DeleteBeerCommandHandler : IRequestHandler<DeleteBeerCommand, Unit>
    {
        private readonly IBeerDbContext _db;
        
        public DeleteBeerCommandHandler(IBeerDbContext db) => _db = db;
        
        public async Task<Unit> Handle(DeleteBeerCommand request, CancellationToken cancellationToken)
        {
            var beer = await _db.Beers.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (beer != null)
            {
                _db.Beers.Remove(beer);
                await _db.SaveChangesAsync(cancellationToken);
            }

            return new Unit();
        }
    }
}
