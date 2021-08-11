using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CRUD_DAL.Interface;

namespace CRUD_DAL.Entities
{
    public class Skill : Entity
    {
        public string Name { get; set; }
    }
}
