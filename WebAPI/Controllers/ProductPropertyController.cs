using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPropertyController : ControllerBase
    {
        IProductPropertyService _productPropertyService;
        public ProductPropertyController(IProductPropertyService productPropertyService)
        {
            _productPropertyService = productPropertyService;
        }
        [HttpGet("getproduct")]
        public IActionResult GetProductProperty(int id)
        {
            var result = _productPropertyService.GetById(id);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
