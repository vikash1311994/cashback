using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using Microsoft.Http;

namespace CashBack.Tests.LinkShare
{
    /// <summary>
    /// Summary description for LinkShareTest
    /// </summary>
    [TestClass]
    public class LinkShareTest
    {
        public LinkShareTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void GetProductsWithQueryStringRelative()
        {
            var serializer = new XmlSerializer(typeof(Crawler.Model.LinkShare.result));

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://feed.linksynergy.com");

            HttpQueryString query = new HttpQueryString();
            query.Add("token", "5bfb339580a02308573204c2ac1bb921ecba09ba542a19d271c2d7e9c27a509f");
            query.Add("keyword", "DVD Player");
            query.Add("Page", "1");
            query.Add("MaxResults", "100");


            var uri = HttpQueryString.MakeQueryString(new Uri("/productsearch?", UriKind.Relative), query);
            var req = new HttpRequestMessage("GET", uri);

            using (var response = client.Send(req))
            {
                //string results = response.Content.ReadAsString();
                var extended = (object)serializer.Deserialize(response.Content.ReadAsStream());
            }
        }
    }
}
