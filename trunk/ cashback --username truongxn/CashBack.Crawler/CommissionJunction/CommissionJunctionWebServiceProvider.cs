using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using Microsoft.Http;
using System.Configuration;

using CashBack.Crawler.Model.CJ;
using CashBack.Data;
using CashBack.Services;

namespace CashBack.Crawler
{
    public class CommissionJunctionWebServiceProvider : Provider
    {
        private HttpClient client;
        private const string METHOD = "/v2/product-search?";
        private Model.CJ.cjapi responseContent;
        private HttpRequestMessage request;

        public CommissionJunctionWebServiceProvider(ICatalogService service)
            : base(service)
        {
        }

        public CommissionJunctionWebServiceProvider()
            : base(new CatalogService())
        { }

        public override void Execute()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Crawler.Model.CJ.cjapi));

                //Build Client
                BuildClient();
                //Build Request
                BuildRequest();

                using (var response = client.Send(request))
                {
                    responseContent = (Crawler.Model.CJ.cjapi)serializer.Deserialize(response.Content.ReadAsStream());
                }

            }
            catch { }
        }

        private void BuildClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(ConfigurationManager.AppSettings["cjProductSearch"]);
        }

        private void BuildRequest()
        {
            HttpQueryString query = new HttpQueryString();
            query.Add(Model.CJ.QueryConstants.WebsiteID, ConfigurationManager.AppSettings["cjSiteID"]);
            query.Add(Model.CJ.QueryConstants.PageNumber, "1");
            query.Add(Model.CJ.QueryConstants.RecordsPerPage, "1000");

            var uri = HttpQueryString.MakeQueryString(new Uri(METHOD, UriKind.Relative), query);
            request = new HttpRequestMessage("GET", uri);

            request.Headers.Add(Model.CJ.QueryConstants.Authorization, ConfigurationManager.AppSettings["cjDeveloperKey"]);
        }
    }
}
