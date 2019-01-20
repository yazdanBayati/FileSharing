using System.Threading.Tasks;
using Core;
using DataAccess;
using Infrastructure;
using NUnit.Framework;
using Services.Controllers;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private IUnitOfWorkFactory _unitOfWorkFactory;
        private IRepositoryFactory _repoFactory;
        private FileController _fileCrtl;
        public  Tests()
        {
            var config = new DbConfig();
            config.ConnectionString = "Host=localhost; Database =FileSharingDB;Username=postgres;Password=123;";
            config.IsDevEnv = true;
            this._repoFactory = new RepositoryFactory();
            this._unitOfWorkFactory = new EntityFrameworkFactory(config);
            this._fileCrtl = new FileController(this._unitOfWorkFactory, _repoFactory);
        }

        [Test]
        public async Task Test1()
        {
            await this._fileCrtl.Get();
            Assert.Pass();
        }
    }
}