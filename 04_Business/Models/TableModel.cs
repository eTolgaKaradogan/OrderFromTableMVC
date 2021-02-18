using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using AppCore.Records.Bases;

namespace _04_Business.Models
{
    public class TableModel : RecordBase
    {
        [Required]
        public string Name { get; set; }

        [DisplayName("Total Price")]
        public double TotalPrice { get; set; }

        [DisplayName("Order Notes")]
        [StringLength(500)]
        public string OrderNote { get; set; }
    }
}
