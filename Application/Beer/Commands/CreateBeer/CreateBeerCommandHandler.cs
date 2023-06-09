namespace Application.Beer.Commands.CreateBeer
{
    using AutoMapper;
    using Domain;
    using Interfaces;
    using MediatR;

    public class CreateBeerCommandHandler : IRequestHandler<CreateBeerCommand, Guid>
    {

        private readonly IBeerDbContext _db;
        private readonly IMapper _mapper;
        
        public CreateBeerCommandHandler(IBeerDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateBeerCommand request, CancellationToken cancellationToken)
        {
            var beer = _mapper.Map<Beer>(request);
            beer.Id = Guid.NewGuid();
            await _db.Beers.AddAsync(beer, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return beer.Id;
        }
    }
}
