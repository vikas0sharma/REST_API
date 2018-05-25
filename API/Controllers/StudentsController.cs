using API.DataModel;
using API.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace API.Controllers
{
  public class StudentsController : ApiController
  {
    private IStudentService _studentService;
    //public StudentsController(IStudentService studentService)
    //{
    //  _studentService = studentService;
    //}
    // GET: api/Students
    public IEnumerable<string> Get()
    {
      return new string[] { "value1", "value2" };
    }

    // GET: api/Students/5
    public string Get(int id)
    {
      IDatabaseProvider db = new DatabaseProvider();
      _studentService = new StudentService(db);
      var s = _studentService.GetStudentById(1);
      return "value";
    }

    // POST: api/Students
    public void Post([FromBody]string value)
    {
    }

    // PUT: api/Students/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE: api/Students/5
    public void Delete(int id)
    {
    }
  }
}
