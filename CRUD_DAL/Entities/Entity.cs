using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using CRUD_DAL.Interface;

namespace CRUD_DAL.Entities
{
    public class Entity : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public bool IsDeleted { get; set; }
    }
}
