using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class OrderDetailsManager : IOrderDetailsService
    {
        IOrderDetailsDal _orderDetails;
        public OrderDetailsManager(IOrderDetailsDal orderDetails)
        {
            _orderDetails = orderDetails;
        }

        public IResult Add(OrderDetail orderDetail)
        {
            _orderDetails.Add(orderDetail);
            return new SuccessResult();
        }

        public IResult Delete(int orderDetailtId)
        {
            _orderDetails.Delete(orderDetailtId);
            return new SuccessResult();
        }

        public IDataResult<List<OrderDetail>> GetAll()
        {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetails.GetAll());
        }

        public IDataResult<OrderDetail> GetById(int orderDetailId)
        {
            return new SuccessDataResult<OrderDetail>(_orderDetails.Get(i => i.OrderId == orderDetailId));
        }

        public IDataResult<List<OrderDetail>> GetUserOrders(int userId)
        {
            return new SuccessDataResult<List<OrderDetail>>(_orderDetails.GetAll(i => i.UserId == userId));
        }

        public IResult Update(OrderDetail orderDetail)
        {
            _orderDetails.Update(orderDetail);
            return new SuccessResult();
        }
    }
}
