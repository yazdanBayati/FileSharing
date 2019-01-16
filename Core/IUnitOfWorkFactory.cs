namespace Core
{
    public interface IUnitOfWorkFactory
    {
         IUintOfWork Create(string connStr);
    }
}