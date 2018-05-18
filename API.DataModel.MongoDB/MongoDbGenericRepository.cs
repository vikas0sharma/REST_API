using API.DataModel;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DataModel.MongoDB
{
  public class MongoDbGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
  {
    private IMongoDatabase _database;
    private string _tableName;
    private IMongoCollection<TEntity> _collection;
    public MongoDbGenericRepository(IMongoDatabase db, string tblName)
    {
      _database = db;
      _tableName = tblName;
      _collection = _database.GetCollection<TEntity>(tblName);
    }
    public async void Add(TEntity entity)
    {
      await _collection.InsertOneAsync(entity);
    }

    public void Delete(object id)
    {
      var builder = Builders<TEntity>.Filter;
      var filter = builder.Eq("_id", id);
      _collection.FindOneAndDelete(filter);
    }

    public IEnumerable<TEntity> Get()
    {
      return  _collection.Find(new BsonDocument()).ToList();
    }

    public TEntity GetByID(object id)
    {
      var builder = Builders<TEntity>.Filter;
      var filter = builder.Eq("_id", id);
      return _collection.Find(filter).FirstOrDefault();
    }

    public void Update(TEntity entity)
    {
      throw new NotImplementedException();
    }
  }
}
