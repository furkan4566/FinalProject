using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment, NorthwindContext>, ICommentDal
    {
        public List<Comment> GetProductComment(int productId)
        {
            using (var context=new NorthwindContext())
            {
                var result = context.Comments.Where(i => i.ProductId == productId);
                return result.ToList();
            }
        }
    }
}
