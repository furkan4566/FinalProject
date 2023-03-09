using Core.Utilities.Results;
using Entities.Concrate;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IProductService
    {
        //List<Product>>  GetAll(); buna dataresult eklemek demek dataresult içindeki massageleri dakullanmak istiyorum demek yani kod degişmedi
        IDataResult<List<Product>> GettAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetAll();
        IResult Add(Product product );
        IResult Update(Product product);
        IResult Delete(int productId);
        IResult AddTransactionTest(Product product);
        IDataResult<List<Product>> GetPopProductFirstTen();
        IDataResult<List<Product>> GetSideCategoryForProduct(int categoryId, int sideCategoryId);
        IDataResult<Product> GetCategoryInPopulerProduct(int categoryId);
        IDataResult<List<Product>> GetAllProductForName(string searchName);
        IDataResult<List<Product>> GetVeryReviewsProduct();
        
    }
}
