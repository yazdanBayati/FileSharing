namespace Core
{
    public interface IUintOfWork
    {
       void Start();
       // void SaveChanges();
        void Commit();
        void Commit(int userId);

      //  void Rollback();
    }
}