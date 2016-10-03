using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace GameInventory.Models
{
    public class GameOwnerMetadata
    {
        [Display(Name = "Owner Id")]
        public int GameOwnerId { get; set; }
        [Display(Name = "Owner")]
        public string GameOwnerName { get; set; }
        [Display(Name = "User Id")]
        public Nullable<int> OwnerUserId { get; set; }

        [Display(Name = "Games")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameModel> Games { get; set; }
    }
    public class GameRegionMetadata
    {
        [Display(Name = "Region Id")]
        public int GameRegionId { get; set; }
        [Display(Name ="Region")]
        public string GameRegionName { get; set; }

        [Display(Name = "Games")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameModel> Games { get; set; }

    }
    public class PlatformMetadata
    {
        [Display(Name = "Platform Id")]
        public int PlatformId { get; set; }
        [Display(Name = "Platform")]
        public string PlatformName { get; set; }
        [Display(Name = "Company Id")]
        public int CompanyId { get; set; }
        [Display(Name = "Company")]
        public virtual GameCompanyModel GameCompany { get; set; }
        [Display(Name = "Games")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameModel> Games { get; set; }
    }
    public class GameCompanyMetadata
    {
        [Display(Name = "Company Id")]
        public int GameCompanyId { get; set; }
        [Display(Name = "Company Name")]
        public string GameCompanyName { get; set; }

        [Display(Name = "Platforms")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlatformModel> Platforms { get; set; }
        [Display(Name = "GamesPublisher")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameModel> Games { get; set; }
        [Display(Name = "GamesDevelopwer")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameModel> Games1 { get; set; }
    }

    public class GameMetadata
    {
        [Display(Name = "Id")]
        public int GameId { get; set; }
        [Display(Name = "Platform Id")]
        public int PlatformId { get; set; }
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Display(Name = "Developer Id")]
        public Nullable<int> DeveloperId { get; set; }
        [Display(Name = "Region Id")]
        public Nullable<int> RegionId { get; set; }
        [Display(Name = "Publisher Id")]
        public Nullable<int> PublisherId { get; set; }
        [Display(Name = "Case?")]
        public Nullable<bool> HasCase { get; set; }
        [Display(Name = "Manual?")]
        public Nullable<bool> HasManual { get; set; }
        [Display(Name = "Model#")]
        public string ModelName { get; set; }
        [Display(Name = "Accessory?")]
        public Nullable<bool> HasAccessory { get; set; }
        [Display(Name = "Owner Id")]
        public Nullable<int> OwnerId { get; set; }
        [Display(Name = "Notes")]
        public string Notes { get; set; }
        [Display(Name = "Developer")]
        public virtual GameCompanyModel GameCompany { get; set; }
        [Display(Name = "Publisher")]
        public virtual GameCompanyModel GameCompany1 { get; set; }
        [Display(Name = "Owner")]
        public virtual GameOwner GameOwner { get; set; }
        [Display(Name = "Region")]
        public virtual GameRegion GameRegion { get; set; }
        [Display(Name = "Platform")]
        public virtual PlatformModel Platform { get; set; }
    }

    public class EnrollmentMetadata
    {
        [Range(0, 4)]
        public Nullable<decimal> Grade;
    }
}