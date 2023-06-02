namespace Application
{
    using Beer.Commands.CreateBeer;
    using Beer.Commands.UpdateBeet;
    using Beer.Queries.GetBeerDetails;
    using Beer.Queries.GetBeerList;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;
    using System.Reflection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(cfg => {
                cfg.AddProfile<BeerDetailsProfile>();
                cfg.AddProfile<GetBeerListProfile>();
                cfg.AddProfile<CreateBeerProfile>();
                cfg.AddProfile<UpdateBeerProfile>();
            });
            return services;
        }
    }
}
