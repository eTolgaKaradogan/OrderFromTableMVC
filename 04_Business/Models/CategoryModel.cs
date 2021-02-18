using System;
using System.ComponentModel.DataAnnotations;
using AppCore.Records.Bases;

namespace _04_Business.Models
{
    public class CategoryModel : RecordBase
    {
        [Required]
        public string Name { get; set; }

    }
}
