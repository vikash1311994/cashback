using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CashBack.Data;

namespace CashBack.Services
{
    public interface ICrawlerService
    {
        IEnumerable<Provider> GetActiveProviders();
        Provider UpdateLastRun(Provider providerToUpdate);
        Provider GetProvider(int id);
    }
}
