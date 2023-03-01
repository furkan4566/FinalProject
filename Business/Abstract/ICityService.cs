using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICityService
    {
        IDataResult<City> GetById(int cityId);
        IDataResult<List<City>> GetAll();
        IResult Add(City city);
        IResult Update(City city);
        IResult Delete(int cityId);
         IDataResult<List<District>> GetDistrictsId(int cityId);
    }
}
