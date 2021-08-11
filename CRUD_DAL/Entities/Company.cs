using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CRUD_DAL.Interface;

namespace CRUD_DAL.Entities
{
    public class Company : Entity
    {
        public string Name { get; set; }
    }
}
