using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;
        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;       
        }
        public IResult Add(Basket basket)
        {
            var result = _basketDal.Get(i => i.ProductId == basket.ProductId);
            if (result !=null)
            {
               result.Quantity += 1;
                _basketDal.Update(result);//front-end de yap 
                return new SuccessResult();
            }
            _basketDal.Add(basket);
            return new SuccessResult();

        }

        public IResult Delete(int baskettId)
        {
            var result=_basketDal.Get(s => s.Id == baskettId);
            _basketDal.Delete(result.Id);
             return new SuccessResult();
        }

        public IDataResult<List<Basket>> GetAll(int userId)
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll(i=>i.UserId==userId));
        }

        public IDataResult<Basket> GetById(int baskettId)
        {
            return new SuccessDataResult<Basket>(_basketDal.Get(i=>i.Id == baskettId));
        }

        public IResult Update(Basket basket)
        {
            _basketDal.Update(basket);
            return new SuccessResult();
        }
    }
}
