using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CRUD_BAL.Interface;
using CRUD_DAL.Entities;

namespace CRUDAspNetCore5WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyDetailsController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyDetailsController(ICompanyService productService) => _companyService = productService;

        [HttpPost("AddCompanies")]
        public async Task<object> AddCompany([FromBody] Company company)
        {
            try
            {
                await _companyService.AddAsync(company);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpDelete("DeleteCompany")]
        public bool DeleteCompany([FromBody] Company company)
        {
            try
            {
                _companyService.Delete(company);
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpGet("GetCompany")]
        public async Task<object> GetById(int id)
        {
            try
            {
                return await Task.FromResult(_companyService.GetByIdAsync(id));
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpGet("GetAllCompanies")]
        public async Task<object> GetAll()
        {
            try
            {
                return await Task.FromResult(_companyService.GetAllAsync());
            }
            catch (Exception)
            {
                return false;
            }
        }

        [HttpPatch("UpdateCompany")]
        public void UpdateCompany([FromBody] Company company)
        {
            _companyService.Update(company);
        }
    }
}
