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

        public Provider GetProvider(int id)
        {
            return (from p in db.ProviderSet
                    where p.ProviderID == id
                    select p).FirstOrDefault();
        }

        public Provider UpdateLastRun(Provider providerToUpdate)
        {
            //Get original provider
            var originalProvider = GetProvider(providerToUpdate.ProviderID);

            //Save changes
            db.ApplyPropertyChanges(originalProvider.EntityKey.EntitySetName, providerToUpdate);
            db.SaveChanges();

            return providerToUpdate;
        }
    }
}
