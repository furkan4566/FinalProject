using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<Order> GetById(int orderId);
        IDataResult<List<Order>> GetAll();
        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(int orderId);
        IDataResult<List<Order>> GetUserOrders(int orderId);
    }
}
