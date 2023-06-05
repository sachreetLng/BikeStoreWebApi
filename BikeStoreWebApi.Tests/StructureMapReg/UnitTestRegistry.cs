using Microsoft.Extensions.Configuration;
using Moq;
using Serilog;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreWebApi.Tests.StructureMapReg
{
    public class UnitTestRegistry : Registry
    {
        public UnitTestRegistry()
        {
            Scan(scanner =>
            {
                scanner.TheCallingAssembly();
                scanner.WithDefaultConventions();
                scanner.AssembliesAndExecutablesFromApplicationBaseDirectory
                    (assembly => assembly.GetName().Name.StartsWith("BikeStoreWebApi."));
            }
        );
            var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            var mocklogger = new Mock<Serilog.ILogger>();
            Log.Logger = mocklogger.Object;
            For<Serilog.ILogger>().Use(mocklogger.Object);
        }
    }
}
