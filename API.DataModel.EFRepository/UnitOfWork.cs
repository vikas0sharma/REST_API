using API.Entities;
using System;

namespace API.DataModel.EFRepository
{
  public class UnitOfWork : IUnitOfWork
  {
    private StudentsManagementContext _context = null;
    private EFGenericRepository<Course> _courseRepository;
    private EFGenericRepository<Enrollment> _enrollmentRepository;
    private EFGenericRepository<Student> _studentRepository;
    public UnitOfWork()
    {
      _context = new StudentsManagementContext();
    }
    public IGenericRepository<Course> CourseRepository
    {
      get
      {
        if (_courseRepository == null)
          _courseRepository = new EFGenericRepository<Course>(_context);
        return _courseRepository;
      }
    }

    public IGenericRepository<Enrollment> EnrollmentRepository
    {
      get
      {
        if (_enrollmentRepository == null)
          _enrollmentRepository = new EFGenericRepository<Enrollment>(_context);
        return _enrollmentRepository;
      }
    }

    public IGenericRepository<Student> StudentRepository
    {
      get
      {
        if (_studentRepository == null)
          _studentRepository = new EFGenericRepository<Student>(_context);
        return _studentRepository;
      }
    }

    public void Save()
    {
      try
      {
        _context.SaveChanges();
      }
      catch (Exception)
      {
      }
    }
  }
}
