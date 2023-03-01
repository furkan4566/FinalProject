using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfFavoriteDal : EfEntityRepositoryBase<UserFavorite, NorthwindContext>, IFavoriteDal
    {
        public List<UserFavorite> GetByUserId(int userId)
        {
            using (var context=new NorthwindContext())
            {
                var result = context.favorites.Where(i => i.UserId == userId);
                return result.ToList();
            }
        }
    }
}
