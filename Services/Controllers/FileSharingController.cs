using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace Services.Controllers
{
    public abstract class FileSharingController : ControllerBase
    {
         public FileSharingController(IUnitOfWorkFactory unitOfWorkFactory, IRepositoryFactory repoFactory, IConfiguration Configuration)
         {
             this._unitOfWorkFactory = unitOfWorkFactory;
             this._repoFactory = repoFactory;
             this.cnnStr = Configuration.GetConnectionString("FileSharingConnection");
         }
         protected IUnitOfWorkFactory _unitOfWorkFactory;
         protected IRepositoryFactory _repoFactory;
         protected string cnnStr; 
         private IConfiguration Configuration { get; }
    }
}