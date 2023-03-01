using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpGet("getallbarndid")]
        public IActionResult GetAllBrandId(int brandId)
        {
            var result=_brandService.GetAllBrandId(brandId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
