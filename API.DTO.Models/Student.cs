using System.Collections.Generic;

namespace API.DTO.Models
{
  public class Student
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Grade { get; set; }
    public List<Course> Courses { get; set; }
  }
}
