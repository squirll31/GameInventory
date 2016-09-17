using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;

namespace GameInventory.Models
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Platform
    {
        public Platform()
        {
            //Games = new HashSet<Game>();
            Developer = new GameCompany();
            Publisher = new GameCompany();
            PlatformName = "";
            PlatformId = 0;
            CompanyId = 0;
        }

        [JsonProperty]
        public int PlatformId { get; set; }

        [JsonProperty]
        public string PlatformName { get; set; }

        [JsonProperty]
        public int CompanyId { get; set; }
        public ICollection<Game> Games { get; set; }

        [JsonProperty]
        public GameCompany Developer { get; set; }

        [JsonProperty]
        public GameCompany Publisher { get; set; }

        [JsonProperty]
        public GameCompany GameCompany { get; set; }

        public override string ToString()
        {
            return PlatformName;
        }

        public string DbgString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Platform.PlatformId: {0}\n", PlatformId);
            s.AppendFormat("Platform.PlatformName: {0}\n", PlatformName);
            s.AppendFormat("Platform.CompanyId: {0}\n", CompanyId);
            s.AppendFormat("Platform.Developer.GameCompanyName: {0}\n", Developer.GameCompanyName);
            s.AppendFormat("Platform.Developer.GameCompanyId: {0}\n", Developer.GameCompanyId);
            s.AppendFormat("Platform.Publisher.GameCompanyName: {0}\n", Publisher.GameCompanyName);
            s.AppendFormat("Platform.Publisher.GameCompanyId: {0}\n", Publisher.GameCompanyId);
            return s.ToString();
        }
    }
}