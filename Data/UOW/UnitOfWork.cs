



using data;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    private readonly Dictionary<Type, object> _repositories = new Dictionary<Type, object>();

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }
    public async Task CommitAsync()
    {
        try{
            await _context.SaveChangesAsync();
        }catch(Exception ex){
            throw new Exception(ex.Message);
        }
    }

    public void Dispose()
    {
        _context.Dispose();
        GC.SuppressFinalize(this);
    }

    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
    {
        Type entityType = typeof(TEntity);
        if (!_repositories.ContainsKey(entityType)){
            _repositories[entityType] = new GenericRepository<TEntity>(_context);
        }
        return (IGenericRepository<TEntity>)_repositories[entityType] as IGenericRepository<TEntity> ?? throw new Exception("Repository not found");
    }

    public async Task RollbackAsync()
    {
        await _context.Database.RollbackTransactionAsync();
        Dispose();
    }
}
