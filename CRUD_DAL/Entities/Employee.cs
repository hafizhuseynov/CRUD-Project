using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CRUD_DAL.Interface;

namespace CRUD_DAL.Entities
{

    public class Employee : Entity
    {
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string UserEmail { get; set; }

        [ForeignKey("CompanyId")]
        public int CompanyId { get; set; }
        [ForeignKey("SkillId")]
        public int SkillId { get; set; }
    }
}
