using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBasketService
    {
        IDataResult<Basket> GetById(int baskettId);
        IDataResult<List<Basket>> GetAll(int basketId);
        IResult Add(Basket basket);
        IResult Update(Basket basket);
        IResult Delete(int baskettId);
    }
}
