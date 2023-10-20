//using DAL.Repository.Interfaces;
//using DAL.Repository.Models;
using BLL.Services;
using CrowdFounding_labo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CrowdFounding_labo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserService _repo;
        public UserController(UserService repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult AddUser(UserAddModel usr)
        {
            try
            {
                _repo.Add(usr);
                return CreatedAtAction(nameof(AddUser), usr);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult GetAllUser()
        {
            IEnumerable<UserGetAllModel> usrs = _repo.GetAll();
            return Ok(usrs);
        }


        [HttpGet("{id:int}")]

        public IActionResult GetUser(int id)
        {
            UserGetModel userModel = _repo.Get(id);
            try
            {
                return Ok(userModel);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                _repo.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
        [HttpPut]
        public IActionResult EditUser(UserUpdateModel usr)
        {
            try
            {
                _repo.Update(usr);
                return Ok(usr);
            }
            catch (Exception ex)
            {
                return NotFound();
            }

        }


    }
}
