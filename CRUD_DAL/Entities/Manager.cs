using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CRUD_DAL.Interface;

namespace CRUD_DAL.Entities
{
    public class Manager : Entity
    {
        public string UserName { get; set; }

        public string UserEmail { get; set; }
    }
}
