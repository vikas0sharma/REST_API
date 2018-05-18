using System;

namespace API.Entities
{
  public class Enrollment
  {
    public int Id { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public DateTime ExitDate { get; set; }
    public string ExitReason { get; set; }
    public int StudentId { get; set; }
  }
}
