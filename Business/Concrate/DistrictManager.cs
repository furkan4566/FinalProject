using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class DistrictManager : IDistrictService
    {
        IDistrictDal _districtDal;
        public DistrictManager(IDistrictDal districtDal)
        {
                _districtDal = districtDal;
        }
        public IResult Add(District product)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int districtId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<District>> GetAll()
        {
            return new SuccessDataResult<List<District>>(_districtDal.GetAll());
        }

        public IDataResult<District> GetById(int districtId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(District product)
        {
            throw new NotImplementedException();
        }
    }
}
