using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ISideCategoryService
    {
        IDataResult<List<SideCategory>> GetAll();
        IDataResult<SideCategory> GetById(int sideCategoryId);
        IResult Add(SideCategory sideCategory);
        IResult Update(SideCategory sideCategory);
        IResult Delete(int sideCategoryId);
        IDataResult<List<SideCategory>> GetSideCategory(int categoryId);
    }
}
