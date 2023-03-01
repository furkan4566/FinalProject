using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class UnderCategoryManager : IUnderCategoryService
    {
        IUnderCategoryDal _underCategoryDal;
        public UnderCategoryManager(IUnderCategoryDal underCategoryDal)
        {
            _underCategoryDal = underCategoryDal;
        }

        public IResult Add(UnderCategory underCategory)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int underCategorytId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UnderCategory>> GetAll()
        {
            return new SuccessDataResult<List<UnderCategory>>(_underCategoryDal.GetAll());
        }

        public IDataResult<List<UnderCategory>> GetUnderCategory(int sideCategoryId)
        {
            return new SuccessDataResult<List<UnderCategory>>(_underCategoryDal.GetAll(i=>i.SideCategoryId==sideCategoryId));
        }

        public IDataResult<UnderCategory> GetById(int underCategorytId)
        {
            return new SuccessDataResult<UnderCategory>(_underCategoryDal.Get(i => i.Id == underCategorytId));
        }

        public IResult Update(UnderCategory underCategory)
        {
            throw new NotImplementedException();
        }
    }
}
