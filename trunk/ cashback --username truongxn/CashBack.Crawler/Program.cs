using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

using CashBack.Data;
using CashBack.Services;

namespace CashBack.Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ICatalogService service = new CatalogService();
                IProviderManager manager = new ProviderManager();
                ICrawlerService crawlerService = new CrawlerService();

                if (args.Length > 0)
                {
                    int providerID = 0;
                    if (int.TryParse(args[0], out providerID))
                    {
                        Data.Provider p = crawlerService.GetProvider(providerID);
                        if (p != null)
                        {
                            IProvider provider = GetProviderImplementation(p, service, crawlerService);
                            if (provider != null)
                            {
                                manager.Add(provider);
                                manager.ExecuteAll();
                            }
                        }
                    }
                }
                else
                {
                    IEnumerable<CashBack.Data.Provider> providers = crawlerService.GetActiveProviders();
                    foreach (CashBack.Data.Provider p in providers)
                    {
                        IProvider provider = GetProviderImplementation(p, service, crawlerService);
                        if (provider != null)
                        {
                            if (p.LastRun.HasValue)
                            {
                                TimeSpan ts = DateTime.Now.Subtract(p.LastRun.Value);
                                if (ts.Minutes >= p.RunInterval)
                                    manager.Add(provider);
                            }
                            else
                            {
                                manager.Add(provider);
                            }
                        }
                    }

                    //Execute all providers
                    manager.ExecuteAll();
                }

            }
            catch { }
        }

        static IProvider GetProviderImplementation(Data.Provider provider, ICatalogService service, ICrawlerService crawlerService)
        {
            IProvider retVal = null;
            switch (provider.ProviderID)
            {
                case 1:
                    retVal = new LinkShareFfpProvider();
                    break;
                case 2:
                    retVal = new LinkShareWebServiceProvider();
                    break;
                case 3:
                    retVal = new CommissionJunctionWebServiceProvider(provider, service, crawlerService);
                    break;
                default:
                    break;
            }

            return retVal;
        }
    }
}
