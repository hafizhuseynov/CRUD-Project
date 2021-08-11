using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_BAL.Interface;
using CRUD_DAL.Entities;
using CRUD_DAL.Interface;
using CRUD_DAL.Migrations;

namespace CRUD_BAL.Service
{
    public class EmployeeSkillService : Service<EmployeeSkill>, IEmployeeSkillService
    {
        public EmployeeSkillService(IRepository<EmployeeSkill> repository) : base(repository)
        {
        }
    }
}
