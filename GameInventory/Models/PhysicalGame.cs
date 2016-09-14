using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameInventory.Models
{
    public class PhysicalGame : Game
    {
        public class PhysicalGameInsert
        {
            public string InsertType;
        }

        public bool Box { get; set; }
        public bool Manual { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }
        public string Condition { get; set; }
        public ICollection<PhysicalGameInsert> Inserts { get; set; }
        public string SpecialEdition { get; set; }
    }
}