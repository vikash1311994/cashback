using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CashBack.Data;

namespace CashBack.Crawler
{
    public class CommissionJunctionWebServiceProvider : Provider
    {
        public CommissionJunctionWebServiceProvider(ICatalogRepository repository)
            : base(repository)
        { }

        public CommissionJunctionWebServiceProvider()
            : base(new CatalogRepository())
        { }

        protected override IList<Product> MakeProducts()
        {
            IList<Product> products = new List<Product>();

            return products;
        }
        public override void Execute()
        {
        }
    }
}
