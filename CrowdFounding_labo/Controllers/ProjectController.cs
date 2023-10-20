using DAL.Repository.Interfaces;
using DAL.Repository.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrowdFounding_labo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectRepo _repo;
        public ProjectController(IProjectRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult Add(ProjectAddModel usr)
        {
            try
            {
                _repo.Add(usr);
                return CreatedAtAction(nameof(Add), usr);
            }
            catch (Exception ex)
            {
                return NotFound();
            }
            
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<ProjectGetAllModel> usrs = _repo.GetAll();
            return Ok(usrs);
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            ProjectGetModel userModel = _repo.Get(id);
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
        public IActionResult Delete(int id)
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
        public IActionResult Update(ProjectUpdateModel usr)
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
