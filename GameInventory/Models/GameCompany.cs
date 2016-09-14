using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace GameInventory.Models
{
    public class GameCompany
    {
        public int GameCompanyId { get; set; }
        public string GameCompanyName { get; set; }

        public GameCompany()
        {
            GameCompanyId = 0;
            GameCompanyName = "";
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat(GameCompanyName);
            return s.ToString();
        }
    }
}