using System;
using AppCore.Records.Bases;

namespace _02_Entities.Entities
{
    public class ProductTable : RecordBase
    {
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int TableId { get; set; }

        public Table Table { get; set; }

    }
}
