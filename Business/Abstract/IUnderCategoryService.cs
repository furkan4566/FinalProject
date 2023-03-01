using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUnderCategoryService
    {
        IDataResult<UnderCategory> GetById(int underCategorytId);
        IDataResult<List<UnderCategory>> GetAll();
        IDataResult<List<UnderCategory>> GetUnderCategory(int sideCategoryId);
        IResult Add(UnderCategory underCategory);
        IResult Update(UnderCategory underCategory);
        IResult Delete(int underCategorytId);

    }
}
