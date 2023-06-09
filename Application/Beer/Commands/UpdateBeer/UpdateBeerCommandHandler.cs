namespace Application.Beer.Commands.UpdateBeer
{
    using AutoMapper;
    using Domain;
    using Interfaces;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using UpdateBeer;

    public class UpdateBeerCommandHandler : IRequestHandler<UpdateBeerCommand>
    {

        private readonly IBeerDbContext _db;
        private readonly IMapper _mapper;
        
        public UpdateBeerCommandHandler(IBeerDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateBeerCommand request, CancellationToken cancellationToken)
        {
            var beer = await _db.Beers.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            if (beer != null)
            {
                _db.Beers.Entry(beer).CurrentValues.SetValues(_mapper.Map<Beer>(request));
                await _db.SaveChangesAsync(cancellationToken);
            }

            return Unit.Value;
        }
    }
}
