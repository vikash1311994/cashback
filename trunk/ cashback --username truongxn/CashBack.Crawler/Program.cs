﻿using System;
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

                if (args.Length > 0)
                {
                    int providerID = 0;
                    if (int.TryParse(args[0], out providerID))
                    {
                        IProvider provider = GetProviderImplementation(providerID, service);
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
                                IProvider provider = GetProviderImplementation(id, service);
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

        static IProvider GetProviderImplementation(int providerID, ICatalogService service)
        {
            IProvider retVal = null;
            switch (providerID)
            {
                case 1:
                    retVal = new LinkShareFfpProvider(service);
                    break;
                case 2:
                    retVal = new LinkShareWebServiceProvider(service);
                    break;
                case 3:
                    retVal = new CommissionJunctionWebServiceProvider(service);
                    break;
                default:
                    break;
            }

            return retVal;
        }
    }
}
