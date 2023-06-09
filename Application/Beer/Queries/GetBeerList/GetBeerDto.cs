namespace Application.Beer.Queries.GetBeerList
{
    using AutoMapper;
    using Common;
    using Domain;

    public class GetBeerDto : IMapWith<Beer, GetBeerDto>
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public float AlcoholPercentage { get; set; }
        
        public void Mapping(Profile profile) =>
            profile.CreateMap(typeof(Beer), GetType());
    }  
}
