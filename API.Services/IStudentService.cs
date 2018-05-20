using API.DTO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Services
{
  public interface IStudentService
  {
    Student GetStudentById(int id);
    IEnumerable<Student> GetAllStudents();
    int CreateStudent(Student student);
    bool UpdateStudent(Student student);
    bool DeleteStudent(Student student);
  }
}
