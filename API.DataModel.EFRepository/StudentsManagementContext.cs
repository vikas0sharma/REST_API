using API.Entities;
using System.Data.Entity;

namespace API.DataModel.EFRepository
{
  public class StudentsManagementContext : DbContext
  {
    public StudentsManagementContext() :
      base("StudentsManagementDB")
    {

    }
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Courses { get; set; }
  }
}
