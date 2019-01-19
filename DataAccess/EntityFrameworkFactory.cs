using System;
using Core;

using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EntityFrameworkFactory : IUnitOfWorkFactory
    {
       private DbContextOptionsBuilder _optionsBuilder;
       public EntityFrameworkFactory(DbContextOptionsBuilder optionsBuilder)
       {
           this._optionsBuilder = optionsBuilder;
       }
        public IUintOfWork Create()
        {
            return new FileSharingContext(this._optionsBuilder);
        }
    }
}
