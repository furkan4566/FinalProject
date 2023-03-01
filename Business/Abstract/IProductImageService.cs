using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductImageService
    {
        IDataResult<List<ProductImage>> GetProductImgById(int productId);
        IDataResult<ProductImage> GetById(int productImageId);
        IDataResult<List<ProductImage>> GetAll();
        IResult Add(ProductImage productImage);
        IResult Update(ProductImage productImage);
        IResult Delete(int productImageId);
    }
}
