using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DataModel
{
  public interface IGenericRepository<TEntity> where TEntity : class
  {
    TEntity GetByID(object id);
    IEnumerable<TEntity> Get();
    void Add(TEntity entity);
    void Delete(object id);
    void Update(TEntity entity);
  }
}
