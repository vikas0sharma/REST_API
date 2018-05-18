using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace API.DataModel.EFRepository
{
  public class EFGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
  {
    private StudentsManagementContext _context;
    private DbSet<TEntity> _dbSet;
    public EFGenericRepository(StudentsManagementContext context)
    {
      _context = context;
      _dbSet = _context.Set<TEntity>();
    }
    public void Add(TEntity entity)
    {
      _dbSet.Add(entity);
    }

    public void Delete(object id)
    {
      TEntity entityToDelete = _dbSet.Find(id);
      if (_context.Entry(entityToDelete).State == EntityState.Detached)
      {
        _dbSet.Attach(entityToDelete);
      }
      _dbSet.Remove(entityToDelete);
    }

    public IEnumerable<TEntity> Get()
    {
      IQueryable<TEntity> query = _dbSet;
      return query.ToList();
    }

    public TEntity GetByID(object id)
    {
      return _dbSet.Find(id);
    }

    public void Update(TEntity entity)
    {
      _dbSet.Attach(entity);
      _context.Entry(entity).State = EntityState.Modified;
    }
  }
}
