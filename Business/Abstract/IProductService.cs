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
        IDataResult<List<Product>>  GetAll();
        IDataResult<List<Product>> GettAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product );
        IResult Update(Product product);
        IResult AddTransactionTest(Product product);

    }
}
