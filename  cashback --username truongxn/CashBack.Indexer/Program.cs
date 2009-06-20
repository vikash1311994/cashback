using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

using Microsoft.Practices.ServiceLocation;
using CashBack.Data;
using SolrNet;
using SolrNet.Impl;


namespace CashBack.Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string serverURL = ConfigurationManager.AppSettings["indexServerUrl"];
                Startup.Init<Product>(new SolrConnection(serverURL));
                var solr = ServiceLocator.Current.GetInstance<ISolrOperations<Product>>();

                ICatalogRepository repository = new CatalogRepository();
                IEnumerable<Product> products = repository.GetIndexProducts(DateTime.Now.AddDays(-1).Date);
                foreach (Product p in products)
                {
                    solr.Add(p);
                }
                
                solr.Commit();
                solr.BuildSpellCheckDictionary();
            }
            catch
            {

            }
        }
    }
}
