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
    
    public partial class DigtialGame
    {
        public int DigitalGameId { get; set; }
        public int ServiceId { get; set; }
        public int GameId { get; set; }
    
        public virtual DigitalService DigitalService { get; set; }
        public virtual Game Game { get; set; }
    }
}