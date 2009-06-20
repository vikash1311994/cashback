using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using CashBack.Data;

namespace CashBack.Tests.Data
{
    /// <summary>
    /// Summary description for CatalogRepositoryTest
    /// </summary>
    [TestClass]
    public class CatalogRepositoryTest
    {
        private ICatalogRepository repository;
        public CatalogRepositoryTest()
        {
            repository = new CatalogRepository();
        }

        [TestMethod]
        public void GetAllCategories()
        {
            var categories = repository.GetAllCategories();

            Assert.IsTrue(categories.Count() > 0);
        }
    }
}
