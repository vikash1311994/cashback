﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Xml.Serialization;
using System.Runtime.Serialization;

using Microsoft.Http;
using CashBack.Crawler.Model.CJ;


namespace CashBack.Tests.CommissionJunction
{
    /// <summary>
    /// Summary description for CommissionJunctionTest
    /// </summary>
    [TestClass]
    public class CommissionJunctionTest
    {
        HttpClient httpClient;
        public CommissionJunctionTest()
        {
            httpClient = new HttpClient("https://product-search.api.cj.com");
            httpClient.DefaultHeaders.Add("authorization", "00b171e48c4bc1e70836b252e1c4c40a893f19db0457be8447b1acdbdc0e7e769e1b804c1af54f883326d6147d1365f4b5f031a61740cf0c63a9f4b3d174cebbbf/420a385c3aa9bcd962b9f57ccf2583225758c11999aa6f42db8e90f9126fe0a7110790cd2ccd66a4f1861e89bd33fcfa6f528b494fa183f5d380ca289d18c309");
        }

        [TestMethod]
        public void GetProducts()
        {
            //HttpQueryString query = new HttpQueryString();
            //query.Add("website-id", "3100204");
            //query.Add("keywords", "DVD");
            //query.Add("page-number", "0");
            //query.Add("records-per-page", "10");
            //HttpRequestMessage req = new HttpRequestMessage();
            //req.Headers.Add("authorization", "00b171e48c4bc1e70836b252e1c4c40a893f19db0457be8447b1acdbdc0e7e769e1b804c1af54f883326d6147d1365f4b5f031a61740cf0c63a9f4b3d174cebbbf/420a385c3aa9bcd962b9f57ccf2583225758c11999aa6f42db8e90f9126fe0a7110790cd2ccd66a4f1861e89bd33fcfa6f528b494fa183f5d380ca289d18c309");

            var serializer = new XmlSerializer(typeof(Crawler.Model.CJ.cjapi));
            using (HttpResponseMessage response = httpClient.Get("/v2/product-search?website-id=3100204&keywords=DVD"))
            {
                response.EnsureStatusIsSuccessful();
                //string temp = response.Content.ReadAsString();
                var extended = (object)serializer.Deserialize(response.Content.ReadAsStream());
            }
            
        }

        [TestMethod]
        public void GetProductsWithQueryStringRelative()
        {
            var serializer = new XmlSerializer(typeof(Crawler.Model.CJ.cjapi));

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://product-search.api.cj.com");

            HttpQueryString query = new HttpQueryString();
            query.Add("website-id", "3100204");
            query.Add("keywords", "DVD");
            query.Add("page-number", "1");
            query.Add("records-per-page", "1000");
            

            var uri = HttpQueryString.MakeQueryString(new Uri("/v2/product-search?", UriKind.Relative), query);
            var req = new HttpRequestMessage("GET", uri);
            req.Headers.Add("authorization", "00b171e48c4bc1e70836b252e1c4c40a893f19db0457be8447b1acdbdc0e7e769e1b804c1af54f883326d6147d1365f4b5f031a61740cf0c63a9f4b3d174cebbbf/420a385c3aa9bcd962b9f57ccf2583225758c11999aa6f42db8e90f9126fe0a7110790cd2ccd66a4f1861e89bd33fcfa6f528b494fa183f5d380ca289d18c309");
            
            using (var response = client.Send(req))
            {
                //string results = response.Content.ReadAsString();
                var extended = (object)serializer.Deserialize(response.Content.ReadAsStream());
            }
        }
    }
}
