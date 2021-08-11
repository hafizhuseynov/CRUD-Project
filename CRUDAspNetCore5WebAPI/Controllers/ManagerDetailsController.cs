using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CRUD_BAL.Interface;
using CRUD_DAL.Interface;
using CRUD_DAL.Entities;

namespace CRUDAspNetCore5WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerDetailsController : ControllerBase
    {
        private readonly IManagerService _managerService;

        public ManagerDetailsController(IManagerService productService)
        {
            _managerService = productService;
        }


        [HttpPost("AddPerson")]
        public async Task<object> AddManager([FromBody] Manager manager)
        {
            try
            {
                await _managerService.AddAsync(manager);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


        [HttpDelete("Delete")]
        public bool Delete(Manager person)
        {
            try
            {
                _managerService.Delete(person);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpGet("Get")]
        public async Task<object> GetById(int id)
        {
            try
            {
                return await Task.FromResult(_managerService.GetByIdAsync(id));
            }
            catch (Exception)
            {
                return false;

            }
        }

        [HttpGet("Get-All")]
        public async Task<object> GetAll()
        {
            return await _managerService.GetAllAsync();
        }

        [HttpPatch]
        public void Update(Manager person)
        {
            try
            {
                _managerService.Update(person);
            }
            catch (Exception)
            {
                Console.WriteLine();
                throw;
            }
        }

    }
}
