using Business.Abstract;
using Entities.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService; 
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var employees = _employeeService.GetAll();
            if (employees != null)
            {
                return Ok(employees);
            }
            return BadRequest(employees);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int employeeId)
        {
            var employees = _employeeService.GetById(employeeId);
            if (employees != null)
            {
                return Ok(employees);
            }
            return BadRequest(employees);
        }
        [HttpPost("add")]
        public IActionResult Add(Employee employee)
        {
            var employees = _employeeService.Add(employee);
            if (employees != null)
            {
                return Ok(employees);
            }
            return BadRequest(employees);
        }
        [HttpPost("delete")]
        public IActionResult Delete(int employeeId)
        {
            var employees = _employeeService.Delete(employeeId);
            if (employees != null)
            {
                return Ok(employees);
            }
            return BadRequest(employees);
        }
    }
}
