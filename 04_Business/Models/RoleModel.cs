using System;
using AppCore.Records.Bases;
using System.ComponentModel.DataAnnotations;

namespace _04_Business.Models
{
    public class RoleModel : RecordBase
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
