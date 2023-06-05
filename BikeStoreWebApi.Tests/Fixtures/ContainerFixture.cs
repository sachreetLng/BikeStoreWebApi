using BikeStoreWebApi.Tests.StructureMapReg;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreWebApi.Tests.Fixtures
{
    public class ContainerFixture : IDisposable
    {
        public IContainer Container { get; set; }
        public ContainerFixture()
        {
                Container = new Container();
            Container.Configure(config =>
            {
                config.AddRegistry(new UnitTestRegistry());
            });
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
