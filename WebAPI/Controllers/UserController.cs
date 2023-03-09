using Business.Abstract;
using Core.Entities.Concrate;
using DataAccess.Abstract;
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
    public class UserController : ControllerBase
    {
        IUserService _userService;
        ICityService _cityService;
        IFavoriteDal _favoriteDal;
        IDistrictService _districtDal;

        public UserController(ICityService cityService, IFavoriteDal favoriteDal, IUserService userService, IDistrictService districtDal)
        {
            _cityService = cityService;
            _favoriteDal = favoriteDal;
            _userService = userService;
            _districtDal = districtDal;
        }
        [HttpGet("getalluser")]
        public IActionResult GetAllUser()
        {
            var result = _userService.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallcity")]
        public IActionResult GetAllCity()
        {
            var result = _cityService.GetAll();
            if(result!=null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getuser")]
        public ActionResult GetUser(string userMail)
        {
            var result = _userService.GetByMail(userMail);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Massage);
        }
        [HttpGet("getalldistrict")]
        public IActionResult GetAllDistrict()
        {
            var result = _districtDal.GetAll();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _favoriteDal.GetByUserId(userId);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyiduser")]
        public ActionResult GetById(int userId)
        {
            var result = _userService.GetById(userId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Massage);
        }
        [HttpGet("getuserclaim")]
        public ActionResult GetUserClaims(int userId)
        {
            var result = _userService.GetUserClaims(userId);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result.Massage);
        }
        [HttpPost("update")]
        public IActionResult Update(User user,int id)
        {
            var result = _userService.GetById(id);
            result.Data.FirstName=user.FirstName;
            result.Data.LastName=user.LastName;
            if(user.Email!=null)
            {
                result.Data.Email = user.Email;
            }
            result.Data.Address=user.Address;
            result.Data.DateOfBirth = user.DateOfBirth;
            result.Data.Number = user.Number;
            result.Data.Gender = user.Gender;
            var update=_userService.Update(result.Data);
            if(update != null)
            {
                return Ok(update);
            }
            return BadRequest(update);
        }
    }
}
