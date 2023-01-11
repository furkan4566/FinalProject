using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfSideCategoryDal:EfEntityRepositoryBase<SideCategory,NorthwindContext>,ISideCategoryDal
    {
        public List<SideCategory> GetSideCategory(int categoryId)
        {
            using (var context = new NorthwindContext())
            {
                var result = context.SideCategories.Where(s => s.CategoryId == categoryId).ToList();
                return result;
            }
        }
    }
}
