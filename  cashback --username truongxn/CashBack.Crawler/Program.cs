using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

using CashBack.Data;

namespace CashBack.Crawler
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ICatalogRepository repository = new CatalogRepository();
                IProviderManager manager = new ProviderManager();

                if (args.Length > 0)
                {
                    int providerID = 0;
                    if (int.TryParse(args[0], out providerID))
                    {
                        IProvider provider = GetProviderImplementation(providerID, repository);
                        if(provider != null)
                        {
                            manager.Add(provider);
                            manager.ExecuteAll();
                        }

                    }
                }
                else
                {
                    //Config
                    string providerIDs = ConfigurationManager.AppSettings["providers"];
                    string[] providers = providerIDs.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string p in providers)
                    {
                        int id = 0;
                        if(int.TryParse(p, out id))
                        {
                            if (id > 0)
                            {
                                IProvider provider = GetProviderImplementation(id, repository);
                                if (provider != null)
                                {
                                    manager.Add(provider);
                                }
                            }
                        }
                    }

                    //Execute all providers
                    manager.ExecuteAll();
                }

            }
            catch { }
        }

        static IProvider GetProviderImplementation(int providerID, ICatalogRepository repository)
        {
            IProvider retVal = null;
            switch (providerID)
            {
                case 1:
                    retVal = new LinkShareFfpProvider(repository);
                    break;
                case 2:
                    retVal = new LinkShareWebServiceProvider(repository);
                    break;
                case 3:
                    retVal = new CommissionJunctionWebServiceProvider(repository);
                    break;
                default:
                    break;
            }

            return retVal;
        }
    }
}
