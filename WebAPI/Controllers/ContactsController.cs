using Business.Abstract;
using Entities.Concrate;
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
    public class ContactsController : ControllerBase
    {
        IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpPost("add")]
        public IActionResult Add(Contact contact)
        {
            var result = _contactService.Add(contact);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(int id, Contact contact)
        {
            var refResult = _contactService.GetById(id);
            refResult.Data.Name = contact.Name;
            refResult.Data.Email = contact.Email;
            refResult.Data.Subject = contact.Subject;
            refResult.Data.Description = contact.Description;
            var result = _contactService.Update(refResult.Data);
            if (refResult.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpDelete("delete")]
        public IActionResult Delete(int id)
        {
            var result = _contactService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _contactService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
