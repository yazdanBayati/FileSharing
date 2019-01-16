using System;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public interface IBaseRepository<T>:IDisposable
    where T : class
    {
      #region DefaultAction

       
        void Add(T entity);
        Task AddAsync(T entity);

       
        void Delete(T entity);
        Task DeleteAsync(T entity);
       
        void Delete(int id);
        Task DeleteAsync(int id);

      
        void Update(T entity);
        Task UpdateAsync(T entity);
       

        void Update(T entity, System.Func<T, int> getKey);
        Task UpdateAsync(T entity, System.Func<T, int> getKey);


        
        T Get(int id);
        Task<T> GetAsync(int id);


       
        IQueryable<T> GetAll();
        Task<IQueryable<T>> GetAllAsync();


        void Detach(T entity);
        #endregion

    }
}