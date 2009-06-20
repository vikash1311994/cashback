using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBack.Crawler.Model.CJ
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute("cj-api", Namespace = "", IsNullable = false)]
    public partial class cjapi
    {

        private cjapiProducts productsField;

        /// <remarks/>
        public cjapiProducts products
        {
            get
            {
                return this.productsField;
            }
            set
            {
                this.productsField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cjapiProducts
    {

        private cjapiProductsProduct[] productField;

        private uint totalmatchedField;

        private byte recordsreturnedField;

        private byte pagenumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("product")]
        public cjapiProductsProduct[] product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("total-matched")]
        public uint totalmatched
        {
            get
            {
                return this.totalmatchedField;
            }
            set
            {
                this.totalmatchedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("records-returned")]
        public byte recordsreturned
        {
            get
            {
                return this.recordsreturnedField;
            }
            set
            {
                this.recordsreturnedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("page-number")]
        public byte pagenumber
        {
            get
            {
                return this.pagenumberField;
            }
            set
            {
                this.pagenumberField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3053")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class cjapiProductsProduct
    {

        private uint adidField;

        private uint advertiseridField;

        private string advertisernameField;

        private string buyurlField;

        private string catalogidField;

        private string currencyField;

        private string descriptionField;

        private string imageurlField;

        private object instockField;

        private string isbnField;

        private string manufacturernameField;

        private object manufacturerskuField;

        private string nameField;

        private decimal priceField;

        private decimal retailpriceField;

        private decimal salepriceField;

        private string skuField;

        private ulong upcField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ad-id")]
        public uint adid
        {
            get
            {
                return this.adidField;
            }
            set
            {
                this.adidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("advertiser-id")]
        public uint advertiserid
        {
            get
            {
                return this.advertiseridField;
            }
            set
            {
                this.advertiseridField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("advertiser-name")]
        public string advertisername
        {
            get
            {
                return this.advertisernameField;
            }
            set
            {
                this.advertisernameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buy-url")]
        public string buyurl
        {
            get
            {
                return this.buyurlField;
            }
            set
            {
                this.buyurlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("catalog-id")]
        public string catalogid
        {
            get
            {
                return this.catalogidField;
            }
            set
            {
                this.catalogidField = value;
            }
        }

        /// <remarks/>
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("image-url")]
        public string imageurl
        {
            get
            {
                return this.imageurlField;
            }
            set
            {
                this.imageurlField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("in-stock")]
        public object instock
        {
            get
            {
                return this.instockField;
            }
            set
            {
                this.instockField = value;
            }
        }

        /// <remarks/>
        public string isbn
        {
            get
            {
                return this.isbnField;
            }
            set
            {
                this.isbnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturer-name")]
        public string manufacturername
        {
            get
            {
                return this.manufacturernameField;
            }
            set
            {
                this.manufacturernameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("manufacturer-sku")]
        public object manufacturersku
        {
            get
            {
                return this.manufacturerskuField;
            }
            set
            {
                this.manufacturerskuField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public decimal price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("retail-price")]
        public decimal retailprice
        {
            get
            {
                return this.retailpriceField;
            }
            set
            {
                this.retailpriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("sale-price")]
        public decimal saleprice
        {
            get
            {
                return this.salepriceField;
            }
            set
            {
                this.salepriceField = value;
            }
        }

        /// <remarks/>
        public string sku
        {
            get
            {
                return this.skuField;
            }
            set
            {
                this.skuField = value;
            }
        }

        /// <remarks/>
        public ulong upc
        {
            get
            {
                return this.upcField;
            }
            set
            {
                this.upcField = value;
            }
        }
    }

}
