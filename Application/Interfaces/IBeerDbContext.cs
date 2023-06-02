namespace Application.Interfaces
{
    using Domain;
    using Microsoft.EntityFrameworkCore;

    public interface IBeerDbContext 
    {
        public DbSet<Beer> Beers { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
