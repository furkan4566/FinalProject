using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        IOrderDetailsService _orderDetailsService;
        public OrderDetailsController(IOrderDetailsService orderDetailsService)
        {
            _orderDetailsService = orderDetailsService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _orderDetailsService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getuserorders")]
        public IActionResult GetUserOrders(int userId)
        {
            var result = _orderDetailsService.GetUserOrders(userId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
