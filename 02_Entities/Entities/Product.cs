using System;
using System.Collections.Generic;
using AppCore.Records.Bases;

namespace _02_Entities.Entities
{
    public class Product : RecordBase
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Details { get; set; }

        public bool IsDeleted { get; set; }

        public string ImagePath { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public List<ProductTable> ProductTable { get; set; }

    }
}
