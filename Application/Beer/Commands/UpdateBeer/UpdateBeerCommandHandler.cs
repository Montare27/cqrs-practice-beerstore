namespace Application.Beer.Commands.UpdateBeet
{
    using AutoMapper;
    using Domain;
    using Interfaces;
    using MediatR;

    public class UpdateBeerCommandHandler : IRequestHandler<UpdateBeerCommand, Guid>
    {

        private readonly IBeerDbContext _db;

        private readonly IMapper _mapper;
        
        public UpdateBeerCommandHandler(IBeerDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(UpdateBeerCommand request, CancellationToken cancellationToken)
        {
            var beer = await _db.Beers.FindAsync( new object?[] {request.Id, cancellationToken}, cancellationToken);
            if (beer != null)
            {
                beer = _mapper.Map<Beer>(request);
                return beer.Id;
            }

            return Guid.NewGuid();
        }
    }
}
