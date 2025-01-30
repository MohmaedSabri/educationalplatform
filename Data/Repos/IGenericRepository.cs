public interface IGenericRepository <TEntity> where TEntity : class {

    public Task AddAsync(TEntity entity);
    public void DeleteAsync(TEntity entity);

    public Task<List<TEntity>> GetAllAsync();
    public Task<TEntity> GetByIdAsync(Guid uuid, string[] include = null);

    public Task<bool> UpdateAsync(TEntity entity);



}