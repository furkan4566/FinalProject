using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfCityDal : EfEntityRepositoryBase<City, NorthwindContext>, ICityDal
    {
        public List<District> GetDistrictsId(int cityId)
        {
            using (var context=new NorthwindContext())
            {
                return context.districts.Where(s => s.CityId == cityId).ToList();
            }
        }
    }
}
