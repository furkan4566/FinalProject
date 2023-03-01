using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;
        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public IResult Add(City city)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int cityId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll()); 
        }

        public IDataResult<City> GetById(int cityId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<District>> GetDistrictsId(int cityId)
        {
            return new SuccessDataResult<List<District>>(_cityDal.GetDistrictsId(cityId));
        }

        public IResult Update(City city)
        {
            throw new NotImplementedException();
        }
    }
}
