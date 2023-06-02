namespace CQRSPractice.Application.Beer.Commands.DeleteBeer
{
    using MediatR;

    public class DeleteBeerCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
