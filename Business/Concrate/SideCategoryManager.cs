using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class SideCategoryManager : ISideCategoryService
    {
        ISideCategoryDal _sideCategoryDal;
        public SideCategoryManager(ISideCategoryDal sideCategoryDal)
        {
            _sideCategoryDal = sideCategoryDal;
        }
        public IResult Add(SideCategory sideCategory)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int sideCategoryId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SideCategory>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<SideCategory> GetById(int sideCategoryId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<SideCategory>> GetSideCategory(int categoryId)
        {
            return new SuccessDataResult<List<SideCategory>>(_sideCategoryDal.GetSideCategory(categoryId));
        }

        public IResult Update(SideCategory sideCategory)
        {
            throw new NotImplementedException();
        }
    }
}
