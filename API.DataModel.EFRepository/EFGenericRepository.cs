using API.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DataModel.EFRepository
{
  public class EFGenericRepository<TEntity> : IGenericRepository<TEntity>
  {
    public void Add(TEntity entity)
    {
      throw new NotImplementedException();
    }

    public void Delete(object id)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<TEntity> Get()
    {
      throw new NotImplementedException();
    }

    public TEntity GetByID(object id)
    {
      throw new NotImplementedException();
    }

    public void Update(TEntity entity)
    {
      throw new NotImplementedException();
    }
  }
}
