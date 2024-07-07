namespace Application;

public interface IApplicationDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    // TODO: Add DbSet properties
    
}
