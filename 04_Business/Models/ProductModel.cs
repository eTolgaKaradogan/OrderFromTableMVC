using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AppCore.Records.Bases;

namespace _04_Business.Models
{
    public class ProductModel : RecordBase
    {
        [Required]
        public string Name { get; set; }

        public double Price { get; set; }

        public string Details { get; set; }

        public bool IsDeleted { get; set; }

        public string ImagePath { get; set; }

        public int CategoryId { get; set; }

    }
}
