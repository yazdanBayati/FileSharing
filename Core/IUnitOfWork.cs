namespace Core
{
    public interface IUnitOfWork
    {
       void Start();
       // void SaveChanges();
        void Commit();
        void Commit(int userId);

      //  void Rollback();
    }
}