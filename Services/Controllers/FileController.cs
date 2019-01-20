using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : FileSharingController
    {

        public FileController(IUnitOfWorkFactory unitOfWorkFactory, IRepositoryFactory repoFactory) : base(unitOfWorkFactory, repoFactory)
        {

        }

        //public FileRepository(IFileRepository fileRepo) => this._fileRepo = fileRepo;
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get()
        {
            using (var uow = _unitOfWorkFactory.Create())
            {
                var repo = _repoFactory.Create<IFileRepository>(uow);
                var file = new File()
                {
                    Name = "test2",
                    Path = "test2"
                };
                await repo.AddAsync(file);
                await uow.CommitAsync();
            }

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";

        }

        // POST api/values


        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
