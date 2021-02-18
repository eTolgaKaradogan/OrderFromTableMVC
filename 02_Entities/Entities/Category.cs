using System;
using System.Collections.Generic;
using AppCore.Records.Bases;

namespace _02_Entities.Entities
{
    public class Category : RecordBase
    {
        public string Name { get; set; }

        public List<Product> Product { get; set; }

    }
}
