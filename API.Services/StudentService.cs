using API.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services
{
  public class StudentService : IStudentService
  {
    private readonly IUnitOfWork _unitOfWork;
    public StudentService(IUnitOfWork unitOfWork)
    {
      _unitOfWork = unitOfWork;
    }
    public DTO.Models.Student GetStudentById(int id)
    {
      var student = _unitOfWork.StudentRepository.GetByID(id);
      if(student != null)
      {

      }
      return null;
    }

    public IEnumerable<DTO.Models.Student> GetAllStudents()
    {
      throw new NotImplementedException();
    }

    public int CreateStudent(DTO.Models.Student student)
    {
      throw new NotImplementedException();
    }

    public bool UpdateStudent(DTO.Models.Student student)
    {
      throw new NotImplementedException();
    }

    public bool DeleteStudent(DTO.Models.Student student)
    {
      throw new NotImplementedException();
    }
  }
}
