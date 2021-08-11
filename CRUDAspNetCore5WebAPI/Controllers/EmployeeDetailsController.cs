using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_BAL.Interface;
using CRUD_BAL.ViewModels;
using CRUD_DAL.Entities;
using Microsoft.Extensions.DependencyInjection;

namespace CRUDAspNetCore5WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        private readonly IEmployeeSkillService _employeeSkillService;

        public EmployeeDetailsController(IEmployeeService productService, IEmployeeSkillService employeeSkillService)
        {
            _employeeService = productService;
            _employeeSkillService = employeeSkillService;
        }

        [HttpPost("AddEmployee")]
        public async Task<object> AddEmployee([FromBody] Employee employee)
        {
            try
            {
                await _employeeService.AddAsync(employee);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        [HttpPost("AddSkillToEmployee")]
        public async Task<object> AddSkillToEmployee([FromBody] EmployeeSkillViewModel employeeSkillViewModel)
        {
            var model = new EmployeeSkill()
            {
                EmployeeId = employeeSkillViewModel.EmployeeId,
                SkillId = employeeSkillViewModel.SkillId
            };

            return await _employeeSkillService.AddAsync(model);
        }

        [HttpDelete("DeleteEmployee")]
        public bool Delete(Employee employee)
        {
            try
            {
                _employeeService.Delete(employee);
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        [HttpGet("GetEmployee")]
        public async Task<object> GetById(int id)
        {
            try
            {
                return await Task.FromResult(_employeeService.GetByIdAsync(id));
            }
            catch (Exception )
            {
                return false;
            }
        }

        [HttpGet("GetAllEmployees")]
        public async Task<object> GetAll()
        {
            try
            {
                return await _employeeService.GetAllAsync();
            }
            catch (Exception )
            {
                return false;
            }
        }

        [HttpPatch("UpdateEmployee")]
        public void Update(Employee employee)
        {
            try
            {
                _employeeService.Update(employee);
            }
            catch (Exception )
            {
                Console.WriteLine();
                throw;
            }
        }
    }
}
