


using System.Dynamic;
using System.Linq.Expressions;
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

    public void DeleteAsync(Guid id)
    {
        _dbSet.Remove(_dbSet.Find(id));
    }

    public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> filter = null, string[] include = null)
    {
       if (filter != null)
       {
           return await _dbSet.Where(filter).ToListAsync();
       }
       if(include != null)
       {
           foreach (var includeProperty in include)
           {
               _dbSet.Include(includeProperty); // ✅ Use Include correctly
           }
       }
       return  await _dbSet.ToListAsync();
    }

    

    public Task<List<TEntity>> GetAsync(Expression<Func<TEntity, bool>> filter = null, string[] include = null)
    {
        if(filter != null){
            if(include != null){
                foreach (var includeProperty in include)
                {
                    _dbSet.Include(includeProperty); 
                }
            }
            return _dbSet.Where(filter).ToListAsync();

        }else{
            return null;
        }
    }

    public async Task<TEntity> GetByIdAsync(Guid uuid, string[] include = null)
{
    IQueryable<TEntity> query = _dbSet.AsQueryable();

    if (include != null)
    {
        foreach (var includeProperty in include)
        {
            query = query.Include(includeProperty); // ✅ Use Include correctly
        }
    }

    return await query.FirstOrDefaultAsync(e => EF.Property<Guid>(e, "Id") == uuid);
}


    public Task<bool> UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        return Task.FromResult(true);
    }

    
}
