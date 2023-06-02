namespace CQRSPractice.Application.Beer.Queries.GetBeerList
{
    using MediatR;

    public class GetBeerQuery : IRequest<List<GetBeerDto>>
    {
        public Guid Id { get; set; }
    }
}
