using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DAL.Entities
{
    public class EmployeeSkill : Entity
    {
        public int EmployeeId { get; set; }
        public int SkillId { get; set; }
    }
}
