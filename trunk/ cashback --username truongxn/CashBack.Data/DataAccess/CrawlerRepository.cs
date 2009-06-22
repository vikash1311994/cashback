using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBack.Data
{
    public class CrawlerRepository : ICrawlerRepository
    {
        private CashBackDBEntities db = new CashBackDBEntities();

        public IEnumerable<Provider> GetAllProviders()
        {
            var providers = (from p in db.ProviderSet
                             select p);

            return providers;
        }
    }
}
