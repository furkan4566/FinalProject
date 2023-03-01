using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImgController : ControllerBase
    {
        IProductImageService _productImageService;
        public ProductImgController(IProductImageService productImageService)
        {
            _productImageService = productImageService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productImageService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getproductimgbyid")]
        public IActionResult GetProductImgById(int productId)
        {
            var result = _productImageService.GetProductImgById(productId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
