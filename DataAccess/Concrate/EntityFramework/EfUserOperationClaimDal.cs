using Core.DataAccess.EntityFramework;
using Core.Entities.Concrate;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, NorthwindContext>, IUserOperationClaimDal
    {
        public List<OperationClaim> GetOperationClaim()
        {
            using (var context=new NorthwindContext())
            {
                return context.Set<OperationClaim>().ToList();
            }
        }
    }
}
