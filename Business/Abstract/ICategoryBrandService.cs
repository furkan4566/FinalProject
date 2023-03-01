using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICategoryBrandService
    {
        IDataResult<CategoryBrand> GetById(int categoryBrandId);
        IDataResult<List<CategoryBrand>> GetAll();
        IResult Add(CategoryBrand categoryBrand);
        IResult Update(CategoryBrand categoryBrand);
        IResult Delete(int categoryBrandtId);
        IDataResult<List<CategoryBrand>> GetByCategory(int categoryId);
        IDataResult<List<CategoryBrand>> GetBySideCategory(int sideCategoryId);

    }
}
