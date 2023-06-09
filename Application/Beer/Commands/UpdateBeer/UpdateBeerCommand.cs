namespace Application.Beer.Commands.UpdateBeer
{
    using Application.Common;
    using AutoMapper;
    using Domain;
    using MediatR;

    public class UpdateBeerCommand : IRequest, IMapWith<UpdateBeerCommand, Beer>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Production { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public float AlcoholPercentage { get; set; }
        
        public void Mapping(Profile profile) => 
            profile.CreateMap(GetType(), typeof(Beer));
    }
}
