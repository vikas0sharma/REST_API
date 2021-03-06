﻿using API.DataModel;
using AutoMapper;
using API.Entities;
using Dto = API.DTO.Models;
using System;
using System.Collections.Generic;

namespace API.Services
{
  public class StudentService : IStudentService
  {
    private readonly IUnitOfWork _unitOfWork;
    private readonly IDatabaseProvider _databaseProvider;
    public StudentService(IDatabaseProvider databaseProvider)
    {
      _databaseProvider = databaseProvider;
      _unitOfWork = _databaseProvider.GetUnitOfWork();
    }
    public Dto.Student GetStudentById(int id)
    {
      var student = _unitOfWork.StudentRepository.GetByID(id);
      if(student != null)
      {
        return Mapper.Map<Student, Dto.Student>(student);
      }
      return null;
    }

    public IEnumerable<Dto.Student> GetAllStudents()
    {
      throw new NotImplementedException();
    }

    public int CreateStudent(Dto.Student student)
    {
      throw new NotImplementedException();
    }

    public bool UpdateStudent(Dto.Student student)
    {
      throw new NotImplementedException();
    }

    public bool DeleteStudent(Dto.Student student)
    {
      throw new NotImplementedException();
    }
  }
}
