
public interface IUnitOfWork : IDisposable{
    public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class;
    public Task CommitAsync();

    public Task RollbackAsync();

}