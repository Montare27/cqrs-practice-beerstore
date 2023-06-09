namespace Application.Common
{
    using AutoMapper;

    public interface IMapWith<T, U>
    {
        public void Mapping(Profile profile) =>
            profile.CreateMap(typeof(T), typeof(U));
    }
}
