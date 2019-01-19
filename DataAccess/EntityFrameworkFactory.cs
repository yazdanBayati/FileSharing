using System;
using Core;

using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class EntityFrameworkFactory : IUnitOfWorkFactory
    {
       private string _cnnStr;
       public EntityFrameworkFactory(string cnnStr)
       {
           this._cnnStr = cnnStr;
       }
        public IUintOfWork Create()
        {
            return new FileSharingContext(this._cnnStr);
        }
    }
}
