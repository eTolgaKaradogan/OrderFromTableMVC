using System;
using System.Collections.Generic;
using AppCore.Records.Bases;

namespace _02_Entities.Entities
{
    public class Table : RecordBase
    {
        public string Name { get; set; }

        public double TotalPrice { get; set; }

        public string OrderNote { get; set; }

        public List<ProductTable> ProductTable { get; set; }


    }
}
