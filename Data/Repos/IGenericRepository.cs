using System.Linq.Expressions;

public interface IGenericRepository <TEntity> where TEntity : class {

    public Task AddAsync(TEntity entity);
    public void DeleteAsync(Guid uuid);

    public Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null, string[] include = null);
    public Task<TEntity> GetByIdAsync(Guid uuid, string[] include = null);

    public Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, string[] include = null);

    public Task<bool> UpdateAsync(TEntity entity);



}