using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CashBack.Data;

namespace CashBack.Services
{
    public class CrawlerService : ICrawlerService
    {
        private ICrawlerRepository repository;

        public CrawlerService()
            : this(new CrawlerRepository())
        { }

        public CrawlerService(ICrawlerRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Provider> GetActiveProviders()
        {
            return repository.GetAllProviders().Where(p => p.IsActive == true).ToList();
        }

        public Provider UpdateLastRun(Provider providerToUpdate)
        {
            return repository.UpdateLastRun(providerToUpdate);
        }

        public Provider GetProvider(int id)
        {
            return repository.GetProvider(id);
        }
    }
}
