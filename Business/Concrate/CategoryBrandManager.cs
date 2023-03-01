using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CategoryBrandManager : ICategoryBrandService
    {
        ICategoryBrandDal _categoryBrandDal;
        public CategoryBrandManager(ICategoryBrandDal categoryBrandDal)
        {
            _categoryBrandDal = categoryBrandDal;
        }
        public IResult Add(CategoryBrand categoryBrand)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int categoryBrandtId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CategoryBrand>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CategoryBrand>> GetByCategory(int categoryId)
        {
            return new SuccessDataResult<List<CategoryBrand>>(_categoryBrandDal.GetAll(i=>i.CategoryId==categoryId));
        }

        public IDataResult<CategoryBrand> GetById(int categoryBrandId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CategoryBrand>> GetBySideCategory(int sideCategoryId)
        {
            return new SuccessDataResult<List<CategoryBrand>>(_categoryBrandDal.GetAll(i => i.SideCategoryId == sideCategoryId));
        }

        public IResult Update(CategoryBrand categoryBrand)
        {
            throw new NotImplementedException();
        }
    }
}
