using System;
using System.Collections.Generic;
using AppCore.Records.Bases;

namespace _02_Entities.Entities
{
    public class Role : RecordBase
    {
        public string Name { get; set; }

        public List<User> User { get; set; }


    }
}
