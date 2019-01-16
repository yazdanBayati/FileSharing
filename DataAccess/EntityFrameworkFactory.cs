using System;
using Core;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EntityFrameworkFactory : IUnitOfWorkFactory
    {
        public IUintOfWork Create(string connStr)
        {
            return new FileSharingContext(connStr);
        }
    }
}
