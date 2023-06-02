namespace Application.Beer.Queries.GetBeerList
{
    using AutoMapper;
    using Domain;

    public class GetBeerListProfile : Profile
    {
        public GetBeerListProfile()
        {
            CreateMap<Beer, GetBeerDto>()
                .ForMember(beerVm => beerVm.Id,
                opt => opt.MapFrom(beer => beer.Id))
                .ForMember(beerVm => beerVm.Name,
                opt => opt.MapFrom(beer => beer.Name))
                .ForMember(beerVm => beerVm.AlcoholPercentage,
                opt => opt.MapFrom(beer => beer.AlcoholPercentage));
        }
    }
}
