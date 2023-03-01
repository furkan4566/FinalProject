using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryBrandController : ControllerBase
    {
        ICategoryBrandService _categoryBrandService;
        public CategoryBrandController(ICategoryBrandService categoryBrandService)
        {
            _categoryBrandService = categoryBrandService;
        }

        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _categoryBrandService.GetByCategory(categoryId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbysidecategory")]
        public IActionResult GetBySideCategory(int sideCategoryId)
        {
            var result = _categoryBrandService.GetBySideCategory(sideCategoryId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
