using Core;
using Microsoft.AspNetCore.Mvc;

namespace Services.Controllers
{
    public abstract class FileSharingController : ControllerBase
    {
         public FileSharingController(IUnitOfWorkFactory unitOfWorkFactory)
         {
             this._unitOfWorkFactory = unitOfWorkFactory;
         }
         protected IUnitOfWorkFactory _unitOfWorkFactory;
    }
}