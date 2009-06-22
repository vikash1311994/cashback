using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CashBack.Data;
using CashBack.Services;

namespace CashBack.Crawler.CommissionJunction
{
    public class CommissionJunctionAdvertiserProvidder : Provider
    {
        public CommissionJunctionAdvertiserProvidder(ICatalogService service)
            : base(service)
        { }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
