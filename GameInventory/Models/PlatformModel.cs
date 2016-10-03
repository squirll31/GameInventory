using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace GameInventory.Models
{
    [DataContract]
    public class PlatformModel : BaseItemModel
    {
        [DataMember]
        public int Id {
            get { return _id; }
            set { _id = value; }
        }
        public PlatformModel(int id)
        {
            using (GameInventoryDBEntities db = new GameInventoryDBEntities())
            {
                var p = db.GetPlatformById(id).Single();
                PlatformName = p.Title;
                Id = id;
            }
        }

        public PlatformModel()
        {
            //Games = new HashSet<Game>();
            Developer = new GameCompanyModel();
            Publisher = new GameCompanyModel();
            PlatformName = "";
            Id = 0;
            CompanyId = 0;
        }

        [DataMember]
        public string PlatformName { get; set; }
        [DataMember]
        public int CompanyId { get; set; }
        public ICollection<GameModel> Games { get; set; }
        public GameCompanyModel Developer { get; set; }
        public GameCompanyModel Publisher { get; set; }
        public GameCompanyModel GameCompany { get; set; }

        public override string ToString()
        {
            return PlatformName;
        }

        public string DbgString()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Platform.PlatformId: {0}\n", Id);
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