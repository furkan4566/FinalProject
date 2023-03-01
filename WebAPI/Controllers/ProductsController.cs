using Business.Abstract;
using Business.Concrate;
using DataAccess.Concrate.EntityFramework;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Thread.Sleep(1000);
            var result =_productService.GetAll();
            if (result.Success)
            {
                return Ok(result); 
            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _productService.GettAllByCategoryId(categoryId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
             var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(int id,Product product)
        {
            var refResult = _productService.GetById(id);
            refResult.Data.ProductName = product.ProductName;
            refResult.Data.QuantityPerUnit = product.QuantityPerUnit;
            refResult.Data.Reviews = product.Reviews;
            refResult.Data.UnitPrice = product.UnitPrice;
            refResult.Data.UnitsInStock = product.UnitsInStock;
            var result = _productService.Update(refResult.Data);
            if (refResult.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _productService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Massage);
        }
        [HttpPost("addTransaction")]
        public IActionResult AddTransactionTest(Product product)
        {
            var result = _productService.AddTransactionTest(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getpopcategoryfirst")]
        public IActionResult GetPopProductFirstTen()
        {
            var result = _productService.GetPopProductFirstTen();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getsidecategoryforproduct")]
        public IActionResult GetSideCategoryForProduct(int categoryId, int sideCategoryId)
        {
            var result=_productService.GetSideCategoryForProduct(categoryId, sideCategoryId);
            if (result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcategoryinpopulerproduct")]
        public IActionResult GetCategoryInPopulerProduct(int categoryId)
        {
            var result = _productService.GetCategoryInPopulerProduct(categoryId);
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
