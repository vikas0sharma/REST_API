using System.Data.Entity;

namespace API.DataModel.EFRepository
{
  public class StudentsManagementContext : DbContext
  {
    public StudentsManagementContext() :
      base("StudentsManagement")
    {

    }
  }
}
