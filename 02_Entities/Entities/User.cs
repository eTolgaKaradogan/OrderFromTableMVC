using System;
using System.Collections.Generic;
using AppCore.Records.Bases;

namespace _02_Entities.Entities
{
    public class User : RecordBase
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Active { get; set; }

        public int RoleId { get; set; }

        public Role Role { get; set; }


    }
}
