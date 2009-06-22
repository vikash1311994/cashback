using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CashBack.Data;

namespace CashBack.Services
{
    public class CrawlerService : ICrawlerService
    {
        private ICrawlerRepository _repository;

        public CrawlerService()
            : this(new CrawlerRepository())
        { }

        public CrawlerService(ICrawlerRepository repository)
        {
            _repository = repository;
        }

        public IList<Provider> GetActiveProviders()
        {
            return _repository.GetAllProviders().ToList();
        }
    }
}
