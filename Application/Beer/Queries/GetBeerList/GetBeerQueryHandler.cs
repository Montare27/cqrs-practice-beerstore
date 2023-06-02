namespace Application.Beer.Queries.GetBeerList
{
    using AutoMapper;
    using Interfaces;
    using MediatR;

    public class GetBeerQueryHandler : IRequestHandler<GetBeerQuery, List<GetBeerDto>>
    {
        private readonly IBeerDbContext _db;

        private readonly IMapper _mapper;

        public GetBeerQueryHandler(IBeerDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<List<GetBeerDto>> Handle(GetBeerQuery request, CancellationToken cancellationToken)
        {
            return _mapper.Map<List<GetBeerDto>>(_db.Beers);
        }
    }
}
