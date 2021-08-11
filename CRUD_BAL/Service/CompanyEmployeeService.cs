using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_DAL.Entities;
using CRUD_DAL.Interface;

namespace CRUD_BAL.Service
{
    public class CompanyEmployeeService : Service<CompanyEmployee>
    {
        public CompanyEmployeeService(IRepository<CompanyEmployee> repository) : base(repository)
        {
        }
    }
}
