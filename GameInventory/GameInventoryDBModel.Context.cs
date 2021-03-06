﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class GameInventoryDBEntities : DbContext
    {
        public GameInventoryDBEntities()
            : base("name=GameInventoryDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<CompanyRelationship> CompanyRelationships { get; set; }
        public virtual DbSet<CompanyRelationshipType> CompanyRelationshipTypes { get; set; }
        public virtual DbSet<GameCompany> GameCompanies { get; set; }
        public virtual DbSet<GameOwner> GameOwners { get; set; }
        public virtual DbSet<GameRegion> GameRegions { get; set; }
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<GamesForGameDevView> GamesForGameDevViews { get; set; }
        public virtual DbSet<GamesForGamePubView> GamesForGamePubViews { get; set; }
        public virtual DbSet<Platform> Platforms { get; set; }
        public virtual DbSet<RecentGame> RecentGames { get; set; }
        public virtual DbSet<RecentGamesView> RecentGamesViews { get; set; }
        public virtual DbSet<PhysicalGame> PhysicalGames { get; set; }
        public virtual DbSet<DigitalService> DigitalServices { get; set; }
        public virtual DbSet<DigtialGame> DigtialGames { get; set; }
        public virtual DbSet<WantedGame> WantedGames { get; set; }
        public virtual DbSet<WantedHardware> WantedHardwares { get; set; }
    
        public virtual ObjectResult<Games_SelectAllByPlatform_Result> Games_SelectAllByPlatform(Nullable<int> platformId)
        {
            var platformIdParameter = platformId.HasValue ?
                new ObjectParameter("platformId", platformId) :
                new ObjectParameter("platformId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Games_SelectAllByPlatform_Result>("Games_SelectAllByPlatform", platformIdParameter);
        }
    
        public virtual ObjectResult<Games_SelectAllForDeveloper_Result> Games_SelectAllForDeveloper(Nullable<int> companyId)
        {
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("companyId", companyId) :
                new ObjectParameter("companyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Games_SelectAllForDeveloper_Result>("Games_SelectAllForDeveloper", companyIdParameter);
        }
    
        public virtual ObjectResult<Games_SelectAllForPublisher_Result> Games_SelectAllForPublisher(Nullable<int> companyId)
        {
            var companyIdParameter = companyId.HasValue ?
                new ObjectParameter("companyId", companyId) :
                new ObjectParameter("companyId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Games_SelectAllForPublisher_Result>("Games_SelectAllForPublisher", companyIdParameter);
        }
    
        public virtual ObjectResult<GetGameById_Result> GetGameById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetGameById_Result>("GetGameById", idParameter);
        }
    
        public virtual ObjectResult<GetPlatformById_Result> GetPlatformById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPlatformById_Result>("GetPlatformById", idParameter);
        }
    
        public virtual ObjectResult<string> GetCompanyById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetCompanyById", idParameter);
        }
    
        public virtual ObjectResult<GetPhysicalGameById_Result> GetPhysicalGameById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPhysicalGameById_Result>("GetPhysicalGameById", idParameter);
        }
    
        public virtual ObjectResult<GetDigitalGameById_Result> GetDigitalGameById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDigitalGameById_Result>("GetDigitalGameById", idParameter);
        }
    
        public virtual ObjectResult<GetDigitalGameByGameId_Result> GetDigitalGameByGameId(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDigitalGameByGameId_Result>("GetDigitalGameByGameId", idParameter);
        }
    
        public virtual ObjectResult<GetWantedGameById_Result> GetWantedGameById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetWantedGameById_Result>("GetWantedGameById", idParameter);
        }
    
        public virtual ObjectResult<Prices_SelectByConsoleName_Result> Prices_SelectByConsoleName(string console)
        {
            var consoleParameter = console != null ?
                new ObjectParameter("console", console) :
                new ObjectParameter("console", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Prices_SelectByConsoleName_Result>("Prices_SelectByConsoleName", consoleParameter);
        }
    
        public virtual ObjectResult<string> Prices_SelectConsoleNames()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("Prices_SelectConsoleNames");
        }
    }
}
