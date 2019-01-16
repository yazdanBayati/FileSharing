using System;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories
{
    public  class BaseRepository<T>:IBaseRepository<T>
    where T: class 
    {
        public BaseRepository(FileSharingContext fileSharingContxt)
        {
            this.Context = fileSharingContxt;
        }
        protected FileSharingContext Context { get; set; }
        protected DbSet<T> DbSet { get; set; }

        public void Add(T entity)
        {
            var entry = this.Context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.DbSet.Add(entity);
            }
        }

        public async Task AddAsync(T entity)
        {
             var entry = this.Context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                await this.DbSet.AddAsync(entity);
            }
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Detach(T entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity, Func<T, int> getKey)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity, Func<T, int> getKey)
        {
            throw new NotImplementedException();
        }
    }
}