//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GameInventory
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhysicalGame
    {
        public int Id { get; set; }
        public Nullable<bool> Box { get; set; }
        public Nullable<bool> Manual { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }
    
        public virtual Game Game { get; set; }
    }
}