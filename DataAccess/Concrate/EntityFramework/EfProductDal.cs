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
        public List<Product> GetPopCategoryFirstTen(int categoryId)
        {
            using (var context=new NorthwindContext())
            {

                var result = from p in context.Products
                             where p.CategoryId == categoryId
                             select p;
                return result.ToList();
            }
        }

        public List<Product> GetPopulerProducts()
        {
            using (var context=new NorthwindContext())
            {
                var result = context.Products.OrderByDescending(i => i.SellCount).Take(10);
                return result.ToList();
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
    }
}
