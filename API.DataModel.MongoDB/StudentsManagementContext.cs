using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MongoDB.Driver;

namespace API.DataModel.MongoDB
{
  public class StudentsManagementContext
  {
    private IMongoDatabase _database;
    public StudentsManagementContext()
    {
      string connectionString = ConfigurationManager.AppSettings["MongoDBConectionString"];
      string dbName = ConfigurationManager.AppSettings["MongoDBDatabaseName"];
      var client = new MongoClient(connectionString);
      _database = client.GetDatabase(dbName);
    }
    public IMongoDatabase DataBase
    {
      get { return _database; }
    }
  }
}
