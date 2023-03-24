using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductPropertyService
    {
        IDataResult<ProductProperty> GetById(int productPropertyId);
        IDataResult<List<ProductProperty>> GetAll();
        IResult Add(ProductProperty productProperty);
        IResult Update(ProductProperty productProperty);
        IResult Delete(int productPropertyId);
    }
}
