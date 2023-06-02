namespace CQRSPractice.Application.Beer.Queries.GetBeerDetails
{
    using MediatR;

    public class GetBeerDetailsQuery : IRequest<BeerDetailsDto>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        
    }
}
