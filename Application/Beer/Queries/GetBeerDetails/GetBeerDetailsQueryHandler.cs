namespace Application.Beer.Queries.GetBeerDetails
{
    using AutoMapper;
    using Interfaces;
    using MediatR;

    public class GetBeerDetailsQueryHandler : IRequestHandler<GetBeerDetailsQuery, BeerDetailsDto>
    {
        private readonly IBeerDbContext _db;

        private readonly IMapper _mapper;
        public GetBeerDetailsQueryHandler(IBeerDbContext db, IMapper mapper) => 
            (_db, _mapper) = (db, mapper);
        
        public async Task<BeerDetailsDto> Handle(GetBeerDetailsQuery request, CancellationToken cancellationToken)
        {
            var beer = await _db.Beers.FindAsync(new object?[] { request.Id, cancellationToken }, cancellationToken);
            return _mapper.Map<BeerDetailsDto>(beer);
        }
    }
}
