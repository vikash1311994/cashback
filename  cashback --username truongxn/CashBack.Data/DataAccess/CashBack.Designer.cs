﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3074
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Original file name:
// Generation date: 6/17/2009 10:41:18 PM
namespace CashBack.Data
{
    
    /// <summary>
    /// There are no comments for CashBackDBEntities in the schema.
    /// </summary>
    public partial class CashBackDBEntities : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Initializes a new CashBackDBEntities object using the connection string found in the 'CashBackDBEntities' section of the application configuration file.
        /// </summary>
        public CashBackDBEntities() : 
                base("name=CashBackDBEntities", "CashBackDBEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new CashBackDBEntities object.
        /// </summary>
        public CashBackDBEntities(string connectionString) : 
                base(connectionString, "CashBackDBEntities")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Initialize a new CashBackDBEntities object.
        /// </summary>
        public CashBackDBEntities(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "CashBackDBEntities")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for ProductSet in the schema.
        /// </summary>
        public global::System.Data.Objects.ObjectQuery<Product> ProductSet
        {
            get
            {
                if ((this._ProductSet == null))
                {
                    this._ProductSet = base.CreateQuery<Product>("[ProductSet]");
                }
                return this._ProductSet;
            }
        }
        private global::System.Data.Objects.ObjectQuery<Product> _ProductSet;
        /// <summary>
        /// There are no comments for ProductSet in the schema.
        /// </summary>
        public void AddToProductSet(Product product)
        {
            base.AddObject("ProductSet", product);
        }
    }
    /// <summary>
    /// There are no comments for Models.Product in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="Models", Name="Product")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class Product : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Create a new Product object.
        /// </summary>
        /// <param name="id">Initial value of ID.</param>
        /// <param name="productID">Initial value of ProductID.</param>
        /// <param name="productName">Initial value of ProductName.</param>
        public static Product CreateProduct(int id, string productID, string productName)
        {
            Product product = new Product();
            product.ID = id;
            product.ProductID = productID;
            product.ProductName = productName;
            return product;
        }
        /// <summary>
        /// There are no comments for Property ID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public int ID
        {
            get
            {
                return this._ID;
            }
            set
            {
                this.OnIDChanging(value);
                this.ReportPropertyChanging("ID");
                this._ID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ID");
                this.OnIDChanged();
            }
        }
        private int _ID;
        partial void OnIDChanging(int value);
        partial void OnIDChanged();
        /// <summary>
        /// There are no comments for Property ProductID in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductID
        {
            get
            {
                return this._ProductID;
            }
            set
            {
                this.OnProductIDChanging(value);
                this.ReportPropertyChanging("ProductID");
                this._ProductID = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("ProductID");
                this.OnProductIDChanged();
            }
        }
        private string _ProductID;
        partial void OnProductIDChanging(string value);
        partial void OnProductIDChanged();
        /// <summary>
        /// There are no comments for Property ProductName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName
        {
            get
            {
                return this._ProductName;
            }
            set
            {
                this.OnProductNameChanging(value);
                this.ReportPropertyChanging("ProductName");
                this._ProductName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("ProductName");
                this.OnProductNameChanged();
            }
        }
        private string _ProductName;
        partial void OnProductNameChanging(string value);
        partial void OnProductNameChanged();
        /// <summary>
        /// There are no comments for Property SKU in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string SKU
        {
            get
            {
                return this._SKU;
            }
            set
            {
                this.OnSKUChanging(value);
                this.ReportPropertyChanging("SKU");
                this._SKU = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("SKU");
                this.OnSKUChanged();
            }
        }
        private string _SKU;
        partial void OnSKUChanging(string value);
        partial void OnSKUChanged();
        /// <summary>
        /// There are no comments for Property ProductURL in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductURL
        {
            get
            {
                return this._ProductURL;
            }
            set
            {
                this.OnProductURLChanging(value);
                this.ReportPropertyChanging("ProductURL");
                this._ProductURL = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("ProductURL");
                this.OnProductURLChanged();
            }
        }
        private string _ProductURL;
        partial void OnProductURLChanging(string value);
        partial void OnProductURLChanged();
        /// <summary>
        /// There are no comments for Property ImageURL in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ImageURL
        {
            get
            {
                return this._ImageURL;
            }
            set
            {
                this.OnImageURLChanging(value);
                this.ReportPropertyChanging("ImageURL");
                this._ImageURL = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("ImageURL");
                this.OnImageURLChanged();
            }
        }
        private string _ImageURL;
        partial void OnImageURLChanging(string value);
        partial void OnImageURLChanged();
        /// <summary>
        /// There are no comments for Property BuyURL in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string BuyURL
        {
            get
            {
                return this._BuyURL;
            }
            set
            {
                this.OnBuyURLChanging(value);
                this.ReportPropertyChanging("BuyURL");
                this._BuyURL = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("BuyURL");
                this.OnBuyURLChanged();
            }
        }
        private string _BuyURL;
        partial void OnBuyURLChanging(string value);
        partial void OnBuyURLChanged();
        /// <summary>
        /// There are no comments for Property ShortDescription in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ShortDescription
        {
            get
            {
                return this._ShortDescription;
            }
            set
            {
                this.OnShortDescriptionChanging(value);
                this.ReportPropertyChanging("ShortDescription");
                this._ShortDescription = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("ShortDescription");
                this.OnShortDescriptionChanged();
            }
        }
        private string _ShortDescription;
        partial void OnShortDescriptionChanging(string value);
        partial void OnShortDescriptionChanged();
        /// <summary>
        /// There are no comments for Property LongDescription in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string LongDescription
        {
            get
            {
                return this._LongDescription;
            }
            set
            {
                this.OnLongDescriptionChanging(value);
                this.ReportPropertyChanging("LongDescription");
                this._LongDescription = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("LongDescription");
                this.OnLongDescriptionChanged();
            }
        }
        private string _LongDescription;
        partial void OnLongDescriptionChanging(string value);
        partial void OnLongDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Brand in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Brand
        {
            get
            {
                return this._Brand;
            }
            set
            {
                this.OnBrandChanging(value);
                this.ReportPropertyChanging("Brand");
                this._Brand = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Brand");
                this.OnBrandChanged();
            }
        }
        private string _Brand;
        partial void OnBrandChanging(string value);
        partial void OnBrandChanged();
        /// <summary>
        /// There are no comments for Property Keywords in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Keywords
        {
            get
            {
                return this._Keywords;
            }
            set
            {
                this.OnKeywordsChanging(value);
                this.ReportPropertyChanging("Keywords");
                this._Keywords = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Keywords");
                this.OnKeywordsChanged();
            }
        }
        private string _Keywords;
        partial void OnKeywordsChanging(string value);
        partial void OnKeywordsChanged();
        /// <summary>
        /// There are no comments for Property PartNumber in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string PartNumber
        {
            get
            {
                return this._PartNumber;
            }
            set
            {
                this.OnPartNumberChanging(value);
                this.ReportPropertyChanging("PartNumber");
                this._PartNumber = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("PartNumber");
                this.OnPartNumberChanged();
            }
        }
        private string _PartNumber;
        partial void OnPartNumberChanging(string value);
        partial void OnPartNumberChanged();
        /// <summary>
        /// There are no comments for Property ManufacturerName in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ManufacturerName
        {
            get
            {
                return this._ManufacturerName;
            }
            set
            {
                this.OnManufacturerNameChanging(value);
                this.ReportPropertyChanging("ManufacturerName");
                this._ManufacturerName = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("ManufacturerName");
                this.OnManufacturerNameChanged();
            }
        }
        private string _ManufacturerName;
        partial void OnManufacturerNameChanging(string value);
        partial void OnManufacturerNameChanged();
        /// <summary>
        /// There are no comments for Property UPC in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string UPC
        {
            get
            {
                return this._UPC;
            }
            set
            {
                this.OnUPCChanging(value);
                this.ReportPropertyChanging("UPC");
                this._UPC = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("UPC");
                this.OnUPCChanged();
            }
        }
        private string _UPC;
        partial void OnUPCChanging(string value);
        partial void OnUPCChanged();
        /// <summary>
        /// There are no comments for Property Classification in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<int> Classification
        {
            get
            {
                return this._Classification;
            }
            set
            {
                this.OnClassificationChanging(value);
                this.ReportPropertyChanging("Classification");
                this._Classification = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Classification");
                this.OnClassificationChanged();
            }
        }
        private global::System.Nullable<int> _Classification;
        partial void OnClassificationChanging(global::System.Nullable<int> value);
        partial void OnClassificationChanged();
        /// <summary>
        /// There are no comments for Property Attributes in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Attributes
        {
            get
            {
                return this._Attributes;
            }
            set
            {
                this.OnAttributesChanging(value);
                this.ReportPropertyChanging("Attributes");
                this._Attributes = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Attributes");
                this.OnAttributesChanged();
            }
        }
        private string _Attributes;
        partial void OnAttributesChanging(string value);
        partial void OnAttributesChanged();
        /// <summary>
        /// There are no comments for Property Discount in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<decimal> Discount
        {
            get
            {
                return this._Discount;
            }
            set
            {
                this.OnDiscountChanging(value);
                this.ReportPropertyChanging("Discount");
                this._Discount = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Discount");
                this.OnDiscountChanged();
            }
        }
        private global::System.Nullable<decimal> _Discount;
        partial void OnDiscountChanging(global::System.Nullable<decimal> value);
        partial void OnDiscountChanged();
        /// <summary>
        /// There are no comments for Property DiscountType in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string DiscountType
        {
            get
            {
                return this._DiscountType;
            }
            set
            {
                this.OnDiscountTypeChanging(value);
                this.ReportPropertyChanging("DiscountType");
                this._DiscountType = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("DiscountType");
                this.OnDiscountTypeChanged();
            }
        }
        private string _DiscountType;
        partial void OnDiscountTypeChanging(string value);
        partial void OnDiscountTypeChanged();
        /// <summary>
        /// There are no comments for Property SalePrice in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<decimal> SalePrice
        {
            get
            {
                return this._SalePrice;
            }
            set
            {
                this.OnSalePriceChanging(value);
                this.ReportPropertyChanging("SalePrice");
                this._SalePrice = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("SalePrice");
                this.OnSalePriceChanged();
            }
        }
        private global::System.Nullable<decimal> _SalePrice;
        partial void OnSalePriceChanging(global::System.Nullable<decimal> value);
        partial void OnSalePriceChanged();
        /// <summary>
        /// There are no comments for Property RetailPrice in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<decimal> RetailPrice
        {
            get
            {
                return this._RetailPrice;
            }
            set
            {
                this.OnRetailPriceChanging(value);
                this.ReportPropertyChanging("RetailPrice");
                this._RetailPrice = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("RetailPrice");
                this.OnRetailPriceChanged();
            }
        }
        private global::System.Nullable<decimal> _RetailPrice;
        partial void OnRetailPriceChanging(global::System.Nullable<decimal> value);
        partial void OnRetailPriceChanged();
        /// <summary>
        /// There are no comments for Property BeginDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> BeginDate
        {
            get
            {
                return this._BeginDate;
            }
            set
            {
                this.OnBeginDateChanging(value);
                this.ReportPropertyChanging("BeginDate");
                this._BeginDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("BeginDate");
                this.OnBeginDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _BeginDate;
        partial void OnBeginDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnBeginDateChanged();
        /// <summary>
        /// There are no comments for Property EndDate in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<global::System.DateTime> EndDate
        {
            get
            {
                return this._EndDate;
            }
            set
            {
                this.OnEndDateChanging(value);
                this.ReportPropertyChanging("EndDate");
                this._EndDate = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("EndDate");
                this.OnEndDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _EndDate;
        partial void OnEndDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnEndDateChanged();
        /// <summary>
        /// There are no comments for Property ShippingCost in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<decimal> ShippingCost
        {
            get
            {
                return this._ShippingCost;
            }
            set
            {
                this.OnShippingCostChanging(value);
                this.ReportPropertyChanging("ShippingCost");
                this._ShippingCost = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ShippingCost");
                this.OnShippingCostChanged();
            }
        }
        private global::System.Nullable<decimal> _ShippingCost;
        partial void OnShippingCostChanging(global::System.Nullable<decimal> value);
        partial void OnShippingCostChanged();
        /// <summary>
        /// There are no comments for Property ShippingInformation in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ShippingInformation
        {
            get
            {
                return this._ShippingInformation;
            }
            set
            {
                this.OnShippingInformationChanging(value);
                this.ReportPropertyChanging("ShippingInformation");
                this._ShippingInformation = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("ShippingInformation");
                this.OnShippingInformationChanged();
            }
        }
        private string _ShippingInformation;
        partial void OnShippingInformationChanging(string value);
        partial void OnShippingInformationChanged();
        /// <summary>
        /// There are no comments for Property ShippingAvailability in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string ShippingAvailability
        {
            get
            {
                return this._ShippingAvailability;
            }
            set
            {
                this.OnShippingAvailabilityChanging(value);
                this.ReportPropertyChanging("ShippingAvailability");
                this._ShippingAvailability = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("ShippingAvailability");
                this.OnShippingAvailabilityChanged();
            }
        }
        private string _ShippingAvailability;
        partial void OnShippingAvailabilityChanging(string value);
        partial void OnShippingAvailabilityChanged();
        /// <summary>
        /// There are no comments for Property Currency in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public string Currency
        {
            get
            {
                return this._Currency;
            }
            set
            {
                this.OnCurrencyChanging(value);
                this.ReportPropertyChanging("Currency");
                this._Currency = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("Currency");
                this.OnCurrencyChanged();
            }
        }
        private string _Currency;
        partial void OnCurrencyChanging(string value);
        partial void OnCurrencyChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        public global::System.Nullable<bool> Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this.ReportPropertyChanging("Status");
                this._Status = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("Status");
                this.OnStatusChanged();
            }
        }
        private global::System.Nullable<bool> _Status;
        partial void OnStatusChanging(global::System.Nullable<bool> value);
        partial void OnStatusChanged();
    }
}
