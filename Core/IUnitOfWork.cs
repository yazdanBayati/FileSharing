using System;
using System.Threading.Tasks;

namespace Core
{
    public interface IUintOfWork: IDisposable
    {
       void Start();
       Task StartAsync();
       // void SaveChanges();
        void Commit();
        Task CommitAsync();
        void Commit(int userId);
        Task CommitAsync(int userId);

      //  void Rollback();
    }
}