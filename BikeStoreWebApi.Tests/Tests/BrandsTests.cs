using BikeStores.MSSQL.Data;
using BikeStoreWebApi.Tests.Fixtures;
using Microsoft.Build.Tasks;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStoreWebApi.Tests.Tests
{
    [TestFixture]
    public class BrandsTests
    {
        private BikestoresContext _dataContext;
        private IContainer _container;

        [SetUp]
        public void Setup()
        {
        }

        //[SetUp]
        //public void Setup(DatabaseFixture databaseFixture, ContainerFixture containerFixture)
        //{
        //    this._dataContext = databaseFixture.DataContext;
        //    this._container = containerFixture.Container;
        //}


        public BrandsTests()
        {
            
        }

        //public BrandsTests(DatabaseFixture databaseFixture, ContainerFixture containerFixture)
        //{
        //    this._dataContext = databaseFixture.DataContext;
        //    this._container = containerFixture.Container;
        //}

        //[Test]
        //public void GetBrandShouldReturnBrandValuesAccordingToIDPassedInParameter()
        //{
        //    //Arrange(oh sabh chiza are arranged jo eh test perform krn layi chaidia)
        //  //for example controller instance,request

        //    //Act(we execute System under test(sut))
        //    //call the particular method from controller instance and pass request to it

        //    //Assert
        //    // verify results
        //}

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}
