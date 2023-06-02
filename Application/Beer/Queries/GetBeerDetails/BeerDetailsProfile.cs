namespace Application.Beer.Queries.GetBeerDetails
{
    using AutoMapper;
    using Domain;

    public class BeerDetailsProfile : Profile
    {
        public BeerDetailsProfile()
        {
            CreateMap<Beer, BeerDetailsDto>()
                .ForMember(beerVm => beerVm.Id,
                opt => opt.MapFrom(beer => beer.Id))
                .ForMember(beerVm => beerVm.Name,
                opt => opt.MapFrom(beer => beer.Name))
                .ForMember(beerVm => beerVm.Price,
                opt => opt.MapFrom(beer => beer.Price))
                .ForMember(beerVm => beerVm.Production,
                opt => opt.MapFrom(beer => beer.Production))
                .ForMember(beerVm => beerVm.Country,
                opt => opt.MapFrom(beer => beer.Country))
                .ForMember(beerVm => beerVm.AlcoholPercentage,
                opt => opt.MapFrom(beer => beer.AlcoholPercentage));
        }
    }
}
