using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDistrictService
    {
        IDataResult<District> GetById(int districtId);
        IDataResult<List<District>> GetAll();
        IResult Add(District product);
        IResult Update(District product);
        IResult Delete(int districtId);
    }
}
