using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBack.Data
{
    public interface ICrawlerRepository
    {
        IEnumerable<Provider> GetAllProviders();
        Provider UpdateLastRun(Provider providerToUpdate);
        Provider GetProvider(int id);
    }
}
