namespace Application.Beer.Commands.CreateBeer
{
    using AutoMapper;
    using Common;
    using Domain;
    using MediatR;

    public class CreateBeerCommand : IRequest<Guid>, IMapWith<CreateBeerCommand, Beer>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Production { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public float AlcoholPercentage { get; set; }
        
        public void Mapping(Profile profile) => 
            profile.CreateMap(GetType(), typeof(Beer));
    }
}
