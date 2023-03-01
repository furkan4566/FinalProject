using Core.Utilities.Results;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderDetailsService
    {
        IDataResult<OrderDetail> GetById(int orderDetailId);
        IDataResult<List<OrderDetail>> GetAll();
        IResult Add(OrderDetail orderDetail);
        IResult Update(OrderDetail orderDetail);
        IResult Delete(int orderDetailtId);
        IDataResult<List<OrderDetail>> GetUserOrders(int userId);
    }
}
