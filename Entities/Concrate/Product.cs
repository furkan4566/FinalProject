using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrate
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; } 
        public int SideCategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public int Reviews { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public int SellCount{ get; set; }
        public double StartCount{ get; set; }
        public string ImagePath { get; set; }
        public bool FreeCargo{ get; set; }
        public bool FastCargo { get; set; }
        public int Discount { get; set; }
        public string Seller { get; set; }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Product))
                return false;

            return (ProductId == ((Product)obj).ProductId);
        }

        public override int GetHashCode()
        {
            return ProductId.GetHashCode();
        }

    }
}
