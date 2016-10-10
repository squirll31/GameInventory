using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace GameInventory.Areas.PRGE.Models
{
    public class PRGEWantedHardware : PRGEBaseModel
    {
        public Dictionary<string, string> ProductImageMap { get; set; }

        [DataMember]
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public ICollection<string> AltTitles { get; set; }
        [DataMember]
        public double MaxPrice { get; set; }
        [DataMember]
        public double IdealPrice { get; set; }
        [DataMember]
        public double ExpectedPrice { get; set; }
    }
}