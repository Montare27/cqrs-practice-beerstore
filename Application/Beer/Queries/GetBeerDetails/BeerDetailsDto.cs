namespace Application.Beer.Queries.GetBeerDetails
{
    using AutoMapper;
    using Common;
    using Domain;

    public class BeerDetailsDto : IMapWith<Beer, BeerDetailsDto>
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Production { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public float AlcoholPercentage { get; set; }
        
        public void Mapping(Profile profile) =>
            profile.CreateMap(typeof(Beer), GetType());
    }
}
