using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        IBasketService _basketService;
        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet("getalluserbasket")]
        public IActionResult GetAll(int userId)
        {
            var result=_basketService.GetAll(userId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int basketId)
        {
            var result = _basketService.GetById(basketId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Basket basket)
        {
            var result = _basketService.Add(basket);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int basketId)
        {
            var result = _basketService.Delete(basketId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
