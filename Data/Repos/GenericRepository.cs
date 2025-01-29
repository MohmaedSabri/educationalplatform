


using System.Dynamic;
using data;
using Microsoft.EntityFrameworkCore;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(AppDbContext context){
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }
    public  async Task AddAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public void DeleteAsync(TEntity entity)
    {
        _dbSet.Remove(entity);
    }

    public async Task<List<TEntity>> GetAllAsync()
    {
       return  await _dbSet.ToListAsync();
    }

    public async Task<TEntity> GetByUuIdAsync(Guid uuid, string[] include = null)
    {

        TEntity entity = await _dbSet.FindAsync(uuid);
        if(entity == null){
            return null;
        }
        if(include != null){
            foreach(var includeProp in include){
                _context.Entry(entity).Reference(includeProp).Load();
            }
        }
        return entity;
    }

    public async Task<TEntity> GetByIdAsync(int id, string[] include = null)
    {
        TEntity entity = await _dbSet.FindAsync(id);
        if(entity == null){
            return null;
        }
        if(include != null){
            foreach(var includeProp in include){
                _context.Entry(entity).Reference(includeProp).Load();
            }
        }

        return entity;
    }

    public Task<bool> UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        return Task.FromResult(true);
    }

    
}
