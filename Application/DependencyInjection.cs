namespace Application
{
    using Beer.Commands.CreateBeer;
    using Beer.Commands.UpdateBeer;
    using Beer.Queries.GetBeerDetails;
    using Beer.Queries.GetBeerList;
    using Common;
    using Interfaces;
    using MediatR;
    using Microsoft.Extensions.DependencyInjection;
    using System.Reflection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(cfg => {
                cfg.AddProfile(new AssemblyProfile(Assembly.GetExecutingAssembly()));
                cfg.AddProfile(new AssemblyProfile(typeof(IBeerDbContext).Assembly));
            });
            
            return services;
        }
    }
}
