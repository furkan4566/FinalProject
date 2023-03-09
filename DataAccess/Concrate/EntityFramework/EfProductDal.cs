using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<Product> GetPopProductFirstTen()
        {
            using (var context=new NorthwindContext())
            {
                var result = context.Products.OrderByDescending(i => i.SellCount).Take(10);
                return result.ToList();
            }
        }

        public Product GetCategoryInPopulerProduct(int categoryId)
        {
            using (var context=new NorthwindContext())
            {
                return context.Products.Where(i => i.CategoryId == categoryId).OrderByDescending(s => s.SellCount).FirstOrDefault();
            }
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories                            
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto { ProductId = p.ProductId, ProductName = p.ProductName, CategoryName = c.CategoryName, UnitsInStock = p.UnitsInStock };
                return result.ToList();
            }
        }

        public List<Product> GetAllProductForName(string searchName)
        {
            using (var context=new NorthwindContext())
            {
                var result= from p in context.Products
                            where p.ProductName.Contains(searchName)
                            select p;
                return result.ToList();
            }
        }

        public List<Product> GetVeryReviewsProduct()
        {
            using (var context = new NorthwindContext())
            {
                var result = context.Products.OrderByDescending(i => i.Reviews).Take(6);
                return result.ToList();
            }
        }
    }
}
