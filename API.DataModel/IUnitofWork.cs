using API.Entities;

namespace API.DataModel
{
  public interface IUnitOfWork
  {
    IGenericRepository<Student> StudentRepository { get; }
    IGenericRepository<Course> CourseRepository { get; }
    IGenericRepository<Enrollment> EnrollmentRepository { get; }
    void Save();
  }
}
