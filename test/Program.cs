using API.DataModel.EFRepository;
using API.DataModel.MongoDB;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
  class Program
  {
    static void Main(string[] args)
    {
      //var client = new MongoClient("mongodb+srv://vikas0sharma:Sg4VvX4NW5v08bTQ@cluster0-gxre2.mongodb.net/test?retryWrites=true");
      //var database = client.GetDatabase("test");
      //var repo = new MongoDbGenericRepository<Movie>(database, "Movie");
      //var x = repo.Get();
      //repo.Add(new Movie { Name = "Vikas"});
      var uof = new API.DataModel.MongoDB.UnitOfWork();
      uof.StudentRepository.Add(new API.Entities.Student { Id = 1, FirstName = "vik" });
      uof.Save();
      Console.WriteLine(uof.StudentRepository.GetByID(1).FirstName);
      Console.ReadLine();

    }
    class Movie
    {
      [BsonId]
      public int ID { get; set; }
      public string Name { get; set; }
    }
  }
}
