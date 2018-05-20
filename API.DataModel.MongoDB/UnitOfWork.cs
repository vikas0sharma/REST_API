using API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.DataModel.MongoDB
{
  public class UnitOfWork : IUnitOfWork
  {
    private StudentsManagementContext _context = null;
    private MongoDbGenericRepository<Course> _courseRepository;
    private MongoDbGenericRepository<Enrollment> _enrollmentRepository;
    private MongoDbGenericRepository<Student> _studentRepository;
    public UnitOfWork()
    {
      _context = new StudentsManagementContext();
    }
    public IGenericRepository<Student> StudentRepository
    {
      get
      {
        if (_studentRepository == null)
          _studentRepository = new MongoDbGenericRepository<Student>(_context.DataBase, "Students");
        return _studentRepository;
      }
    }

    public IGenericRepository<Course> CourseRepository
    {
      get
      {
        if (_courseRepository == null)
          _courseRepository = new MongoDbGenericRepository<Course>(_context.DataBase, "Courses");
        return _courseRepository;
      }
    }

    public IGenericRepository<Enrollment> EnrollmentRepository
    {
      get
      {
        if (_enrollmentRepository == null)
          _enrollmentRepository = new MongoDbGenericRepository<Enrollment>(_context.DataBase, "Enrollments");
        return _enrollmentRepository;
      }
    }

    public void Save()
    {
      throw new NotImplementedException();
    }
  }
}
