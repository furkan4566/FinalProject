using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnderCategoryController : ControllerBase
    {
        IUnderCategoryService _underCategoryService;
        public UnderCategoryController(IUnderCategoryService underCategoryService)
        {
            _underCategoryService = underCategoryService;
        }
        [HttpGet("getall")]
        public IActionResult GetUnderCategory()
        {
            //Thread.Sleep(1000);
            var result = _underCategoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getundercategory")]
        public IActionResult GetUnderCategory(int sideCategoryId)
        {
            //Thread.Sleep(1000);
            var result = _underCategoryService.GetUnderCategory(sideCategoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
