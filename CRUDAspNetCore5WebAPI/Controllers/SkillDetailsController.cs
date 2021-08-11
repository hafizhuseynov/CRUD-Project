using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CRUD_BAL.Interface;
using CRUD_DAL.Entities;

namespace CRUDAspNetCore5WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkillDetailsController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillDetailsController(ISkillService productService) => _skillService = productService;

        [HttpPost("AddSkill")]
        public async Task<object> AddSkill([FromBody] Skill skill)
        {
            try
            {
               await _skillService.AddAsync(skill);
                return true;
            }   
            catch
            {
                return false;
            }
        }

        [HttpDelete("DeleteSkill")]
        public bool DeleteSkill([FromBody] Skill skill)
        {
            try
            {
                _skillService.Delete(skill);
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpGet("GetSkill")]
        public async Task<object> GetById(int id)
        {
            try
            {
                return await Task.FromResult(_skillService.GetByIdAsync(id));
            }
            catch 
            {
                return false;
            }
        }

        [HttpGet("GetAll")]
        public async Task<object> GetAll()
        {
            try
            {
                return await Task.FromResult(_skillService.GetAllAsync());
            }
            catch 
            {
                return false;
            }
        }

    }
}
