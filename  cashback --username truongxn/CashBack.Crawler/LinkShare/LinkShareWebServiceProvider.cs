using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CashBack.Data;

namespace CashBack.Crawler
{
    public class LinkShareWebServiceProvider : Provider
    {
        public LinkShareWebServiceProvider(ICatalogRepository repository)
            : base(repository)
        { }

        public LinkShareWebServiceProvider()
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
