namespace Application;

public class IApplicationDbContext
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
