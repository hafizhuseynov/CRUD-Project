using CRUD_BAL.Interface;
using CRUD_DAL.Interface;
using CRUD_DAL.Entities;

namespace CRUD_BAL.Service
{
    public class EmployeeService : Service<Employee>, IEmployeeService
    {
        public EmployeeService(IRepository<Employee> repository) : base(repository)
        {
        }
    }
}
