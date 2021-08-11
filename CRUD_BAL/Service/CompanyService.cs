using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_BAL.Interface;
using CRUD_DAL.Interface;
using CRUD_DAL.Entities;

namespace CRUD_BAL.Service
{
    public class CompanyService : Service<Company>,ICompanyService
    {
        public CompanyService(IRepository<Company> repository) : base(repository)
        {
        }
    }
}
