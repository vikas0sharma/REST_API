namespace API.Entities
{
  public class Course
  {
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    public string CourseName { get; set; }
    public int CourseDuration { get; set; }
  }
}
