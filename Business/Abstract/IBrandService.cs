using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<Brand> GetById(int brandId);
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetAllBrandId(int brandId);
        IResult Add(Brand brand);
        IResult Update(Brand brand);
        IResult Delete(int brandId);
    }
}
