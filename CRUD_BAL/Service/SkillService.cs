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
    public class SkillService : Service<Skill>,ISkillService
    {
        public SkillService(IRepository<Skill> repository) : base(repository)
        {
        }
    }
}
