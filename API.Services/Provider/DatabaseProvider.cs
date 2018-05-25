using API.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace API.Services
{
  public class DatabaseProvider : IDatabaseProvider
  {
    public IUnitOfWork GetUnitOfWork()
    {
      string dbProviderType = WebConfigurationManager.AppSettings["DatabaseProvider"];
      Type type = Type.GetType(dbProviderType);
      object providerObj = Activator.CreateInstance(type);
      if(providerObj is IUnitOfWork)
      {
        return providerObj as IUnitOfWork;
      }
      return null;
    }
  }
}
