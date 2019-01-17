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
        
        public FileController(IUnitOfWorkFactory unitOfWorkFactory, IRepositoryFactory repoFactory, IConfiguration configuration):base(unitOfWorkFactory, repoFactory, configuration)
        {

        }

        //public FileRepository(IFileRepository fileRepo) => this._fileRepo = fileRepo;
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            
            using(this._unitOfWorkFactory.Create(this.cnnStr)){
                
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
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

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
