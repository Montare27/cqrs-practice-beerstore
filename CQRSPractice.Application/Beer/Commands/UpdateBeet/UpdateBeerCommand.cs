namespace CQRSPractice.Application.Beer.Commands.UpdateBeet
{
    using MediatR;

    public class UpdateBeerCommand : IRequest, IRequest<Guid>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Production { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public float AlcoholPercentage { get; set; }
    }
}
