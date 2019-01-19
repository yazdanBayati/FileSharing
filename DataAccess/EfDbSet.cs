using Core;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EfDbSet<TEntity> : DbSet<TEntity>, IDbSet<TEntity>
    where TEntity : class
    {
       
    }
}