using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SideCategoryController : ControllerBase
    {
        ISideCategoryService _sideCategory;
        public SideCategoryController(ISideCategoryService sideCategory)
        {
            _sideCategory = sideCategory;
        }
        [HttpGet("getsidecategory")]
        public IActionResult GetSideCategory(int categoryId)
        {
            var result = _sideCategory.GetSideCategory(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
