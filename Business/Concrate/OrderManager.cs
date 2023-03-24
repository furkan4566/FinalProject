using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDetails;
        public OrderManager(IOrderDal orderDetails)
        {
            _orderDetails = orderDetails;
        }

        public IResult Add(Order order)
        {
            _orderDetails.Add(order);
            return new SuccessResult();
        }

        public IResult Delete(int orderDetailtId)
        {
            _orderDetails.Delete(orderDetailtId);
            return new SuccessResult();
        }

        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDetails.GetAll());
        }

        public IDataResult<Order> GetById(int orderDetailId)
        {
            return new SuccessDataResult<Order>(_orderDetails.Get(i => i.OrderId == orderDetailId));
        }

        public IDataResult<List<Order>> GetUserOrders(int userId)
        {
            return new SuccessDataResult<List<Order>>(_orderDetails.GetAll(i => i.UserId == userId));
        }

        public IResult Update(Order orderDetail)
        {
            _orderDetails.Update(orderDetail);
            return new SuccessResult();
        }
    }
}
