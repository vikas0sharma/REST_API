namespace API.DataModel
{
  public interface IDatabaseProvider
  {
    IUnitOfWork GetUnitOfWork();
  }
}
