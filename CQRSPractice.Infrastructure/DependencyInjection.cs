namespace CQRSPractice.Infrastructure
{
    using Application.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var config = configuration.GetConnectionString("Db");
            services.AddDbContext<BeerDbContext>(cfg =>
                cfg.UseSqlServer(config));

            services.AddScoped<IBeerDbContext>(provider =>
                provider.GetService<BeerDbContext>()!);
            
            return services;
        }
    }
}
