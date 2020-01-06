using System;
using System.Collections.Generic;
using FenixAlliance.Models.DTOs.Components.Commons;
using ProductAttribute = FenixAlliance.Models.DTOs.Components.Commons.ProductAttribute;
using ProductType = FenixAlliance.Models.DTOs.Components.Commons.ProductType;

namespace FenixAlliance.Models.DTOs.Components.Store
{
    public partial class MinimalAPIProduct
    {
        public string CartRecordID { get; set; }
        public string CompareRecordID { get; set; }
        public string ItemID { get; set; }
        public string SKU { get; set; }
        public int TViews { get; set; }
        public string MPN { get; set; }
        public string Model { get; set; }
        public double FinalPrice { get; set; }
        public double RegularPrice { get; set; }
        public double TotalTax { get; set; }
        public double DiscountPrice { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime DiscountDeadLine { get; set; }
        public double PaymentCost { get; set; }
        public double ShippingCost { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public int ReviewsCount { get; set; }
        public int ReviewsAvg { get; set; }
        public bool InStock { get; set; }
        public bool ByRequest { get; set; }
        public bool OnSale { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingCountryFlag { get; set; }
        public double DealSavings { get; set; }

        public int TotalViews { get; set; }
        public List<string> Images { get; set; }
        public string Type { get; set; }
        public string TypeID { get; set; }
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string BrandID { get; set; }
        public string BrandURL { get; set; }
        public string BrandName { get; set; }
        public string BrandLogoURL { get; set; }
    }
    public partial class APIProduct
    {
        public string CartRecordID { get; set; }
        public string CompareRecordID { get; set; }
        public string ItemID { get; set; }
        public string SKU { get; set; }
        public int TViews { get; set; }
        public string MPN { get; set; }
        public string Model { get; set; }
        public double FinalPrice { get; set; }
        public double RegularPrice { get; set; }
        public double TotalTax { get; set; }
        public double DiscountPrice { get; set; }
        public double DealSavings { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime DiscountDeadLine { get; set; }
        public double PaymentCost { get; set; }
        public double ShippingCost { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int ReviewsCount { get; set; }
        public int ReviewsAvg { get; set; }
        public bool InStock { get; set; }
        public bool ByRequest { get; set; }
        public bool OnSale { get; set; }
        public string ShippingCountry { get; set; }
        public string ShippingCountryFlag { get; set; }


        public List<string> Images { get; set; }
        public List<ProductTag> Tags { get; set; }
        public List<ProductView> Views { get; set; }
        public List<ProductType> Types { get; set; }
        public List<Question> Questions { get; set; }
        public List<ProductBrand> Brands { get; set; }
        public List<ProductReview> Reviews { get; set; }
        public List<ProductCategory> Categories { get; set; }
        public List<ProductAttribute> Attributes { get; set; }
    }

    public class Product
    {
        public string CartRecordID { get; set; }
        public string CompareRecordID { get; set; }
        public string ItemID { get; set; }
        public string SKU { get; set; }
        public int TViews { get; set; }
        public string MPN { get; set; }
        public string Title { get; set; }
        public string Model { get; set; }
        public double TotalTax { get; set; }
        public double FinalPrice { get; set; }
        public double RegularPrice { get; set; }
        public double DiscountPrice { get; set; }
        public double DealSavings { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime DiscountDeadLine { get; set; }
        public double PaymentCost { get; set; }
        public double ShippingCost { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int ReviewsCount { get; set; }
        public int ReviewsAvg { get; set; }
        public bool InStock { get; set; }
        public bool ByRequest { get; set; }
        public bool OnSale { get; set; }

        public Country ShippingCountry { get; set; }

        public List<string> Images { get; set; }
        public List<ProductTag> Tags { get; set; }
        public List<ProductView> Views { get; set; }
        public List<ProductType> Types { get; set; }
        public List<Question> Questions { get; set; }
        public List<ProductBrand> Brands { get; set; }
        public List<ProductReview> Reviews { get; set; }
        public List<ProductCategory> Categories { get; set; }
        public List<ProductAttribute> Attributes { get; set; }
    }


}
