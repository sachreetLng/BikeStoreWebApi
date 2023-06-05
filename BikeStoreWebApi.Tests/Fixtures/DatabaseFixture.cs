using BikeStores.MSSQL.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreWebApi.Tests.Fixtures
{
    public class DatabaseFixture
    {
        public BikestoresContext DataContext { get; set; }
        public DatabaseFixture()
        {
            var options = new DbContextOptionsBuilder<BikestoresContext>()
              .UseInMemoryDatabase(databaseName: "BikeStoreDB" + DateTime.Now.ToFileTime())
              .Options;
            DataContext = new BikestoresContext(options);
        }
    }
}
