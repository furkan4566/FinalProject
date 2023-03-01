using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ProductImageManager : IProductImageService
    {
        IProductImgDal _productImg;
        public ProductImageManager(IProductImgDal productImg)
        {
            _productImg = productImg;
        }

        public IResult Add(ProductImage productImage)
        {
            _productImg.Add(productImage);
            return new SuccessResult();
        }

        public IResult Delete(int productImageId)
        {
            _productImg.Delete(productImageId);
            return new SuccessResult();
        }

        public IDataResult<List<ProductImage>> GetAll()
        {
            return new SuccessDataResult<List<ProductImage>>(_productImg.GetAll());
        }

        public IDataResult<ProductImage> GetById(int productImageId)
        {
            return new SuccessDataResult<ProductImage>(_productImg.Get(i=>i.Id==productImageId));
        }

        public IDataResult<List<ProductImage>> GetProductImgById(int productId)
        {
            return new SuccessDataResult<List<ProductImage>>(_productImg.GetAll(i => i.ProductId == productId));

        }

        public IResult Update(ProductImage productImage)
        {
            _productImg.Update(productImage);
            return new SuccessResult();
        }
    }
}
