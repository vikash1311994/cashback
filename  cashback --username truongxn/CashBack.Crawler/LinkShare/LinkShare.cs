using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBack.Crawler.Model.LinkShare
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class result
    {

        private ushort totalMatchesField;

        private byte totalPagesField;

        private byte pageNumberField;

        private resultItem[] itemField;

        /// <remarks/>
        public ushort TotalMatches
        {
            get
            {
                return this.totalMatchesField;
            }
            set
            {
                this.totalMatchesField = value;
            }
        }

        /// <remarks/>
        public byte TotalPages
        {
            get
            {
                return this.totalPagesField;
            }
            set
            {
                this.totalPagesField = value;
            }
        }

        /// <remarks/>
        public byte PageNumber
        {
            get
            {
                return this.pageNumberField;
            }
            set
            {
                this.pageNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public resultItem[] item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultItem
    {

        private ushort midField;

        private string merchantnameField;

        private uint linkidField;

        private string createdonField;

        private string skuField;

        private string productnameField;

        private resultItemCategory categoryField;

        private resultItemPrice priceField;

        private string upccodeField;

        private resultItemDescription descriptionField;

        private string keywordsField;

        private string linkurlField;

        private string imageurlField;

        /// <remarks/>
        public ushort mid
        {
            get
            {
                return this.midField;
            }
            set
            {
                this.midField = value;
            }
        }

        /// <remarks/>
        public string merchantname
        {
            get
            {
                return this.merchantnameField;
            }
            set
            {
                this.merchantnameField = value;
            }
        }

        /// <remarks/>
        public uint linkid
        {
            get
            {
                return this.linkidField;
            }
            set
            {
                this.linkidField = value;
            }
        }

        /// <remarks/>
        public string createdon
        {
            get
            {
                return this.createdonField;
            }
            set
            {
                this.createdonField = value;
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
        public string productname
        {
            get
            {
                return this.productnameField;
            }
            set
            {
                this.productnameField = value;
            }
        }

        /// <remarks/>
        public resultItemCategory category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public resultItemPrice price
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
        public string upccode
        {
            get
            {
                return this.upccodeField;
            }
            set
            {
                this.upccodeField = value;
            }
        }

        /// <remarks/>
        public resultItemDescription description
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
        public string keywords
        {
            get
            {
                return this.keywordsField;
            }
            set
            {
                this.keywordsField = value;
            }
        }

        /// <remarks/>
        public string linkurl
        {
            get
            {
                return this.linkurlField;
            }
            set
            {
                this.linkurlField = value;
            }
        }

        /// <remarks/>
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
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultItemCategory
    {

        private string primaryField;

        private string secondaryField;

        /// <remarks/>
        public string primary
        {
            get
            {
                return this.primaryField;
            }
            set
            {
                this.primaryField = value;
            }
        }

        /// <remarks/>
        public string secondary
        {
            get
            {
                return this.secondaryField;
            }
            set
            {
                this.secondaryField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultItemPrice
    {

        private string currencyField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.3074")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class resultItemDescription
    {

        private string shortField;

        private string longField;

        /// <remarks/>
        public string @short
        {
            get
            {
                return this.shortField;
            }
            set
            {
                this.shortField = value;
            }
        }

        /// <remarks/>
        public string @long
        {
            get
            {
                return this.longField;
            }
            set
            {
                this.longField = value;
            }
        }
    }

}
