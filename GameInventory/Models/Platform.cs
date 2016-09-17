using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace GameInventory.Models
{
    public class Platform
    {
        public Platform()
        {
            Games = new HashSet<Game>();
            Developer = new GameCompany();
            Publisher = new GameCompany();
            GameCompany = new GameCompany();
            PlatformName = "";
            PlatformId = 0;
            CompanyId = 0;
        }

        public int PlatformId { get; set; }
        public string PlatformName { get; set; }
        public int CompanyId { get; set; }
        public ICollection<Game> Games { get; set; }
        public GameCompany Developer { get; set; }
        public GameCompany Publisher{ get; set; }
        public GameCompany GameCompany { get; set; }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Platform.PlatformId: {0}\n", PlatformId);
            s.AppendFormat("Platform.PlatformName: {0}\n", PlatformName);
            s.AppendFormat("Platform.CompanyId: {0}\n", CompanyId);
            s.AppendFormat("Platform.Developer.GameCompanyName: {0}\n", Developer.GameCompanyName);
            s.AppendFormat("Platform.Developer.GameCompanyId: {0}\n", Developer.GameCompanyId);
            s.AppendFormat("Platform.Publisher.GameCompanyName: {0}\n", Publisher.GameCompanyName);
            s.AppendFormat("Platform.Publisher.GameCompanyId: {0}\n", Publisher.GameCompanyId);
            s.AppendFormat("Platform.GameCompany.GameCompanyName: {0}\n", GameCompany.GameCompanyName);
            s.AppendFormat("Platform.GameCompany.GameCompanyId: {0}\n", GameCompany.GameCompanyId);
            return s.ToString();
        }
    }
}