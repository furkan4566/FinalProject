using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class ProductPropertyManager : IProductPropertyService
    {
        IProductPropertyDal _productProperty;
        public ProductPropertyManager(IProductPropertyDal productProperty)
        {
            _productProperty = productProperty;
        }

        public IResult Add(ProductProperty productProperty)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int productPropertyId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ProductProperty>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<ProductProperty> GetById(int productPropertyId)
        {
            return new SuccessDataResult<ProductProperty>(_productProperty.Get(i => i.ProductId == productPropertyId));
        }

        public IResult Update(ProductProperty productProperty)
        {
            throw new NotImplementedException();
        }
    }
}
