
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/19/2016 23:28:19
-- Generated from EDMX file: C:\Users\matt\documents\visual studio 2015\Projects\GameInventory\GameInventory\GameInventoryDBModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [GameInventoryDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CompanyRelationship_ToFromCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompanyRelationships] DROP CONSTRAINT [FK_CompanyRelationship_ToFromCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyRelationship_ToToCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompanyRelationships] DROP CONSTRAINT [FK_CompanyRelationship_ToToCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_CompanyRelationships_ToCompanyRelationshipTypes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompanyRelationships] DROP CONSTRAINT [FK_CompanyRelationships_ToCompanyRelationshipTypes];
GO
IF OBJECT_ID(N'[dbo].[FK_Developer_ToGameDevCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Games] DROP CONSTRAINT [FK_Developer_ToGameDevCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_Owner_ToGameOwners]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Games] DROP CONSTRAINT [FK_Owner_ToGameOwners];
GO
IF OBJECT_ID(N'[dbo].[FK_Platform_ToPlatforms]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Games] DROP CONSTRAINT [FK_Platform_ToPlatforms];
GO
IF OBJECT_ID(N'[dbo].[FK_Platforms_ToGameCompanies]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Platforms] DROP CONSTRAINT [FK_Platforms_ToGameCompanies];
GO
IF OBJECT_ID(N'[dbo].[FK_Publisher_ToGamePubCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Games] DROP CONSTRAINT [FK_Publisher_ToGamePubCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_Region_ToGameRegions]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Games] DROP CONSTRAINT [FK_Region_ToGameRegions];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CompanyRelationships]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompanyRelationships];
GO
IF OBJECT_ID(N'[dbo].[CompanyRelationshipTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompanyRelationshipTypes];
GO
IF OBJECT_ID(N'[dbo].[GameCompanies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GameCompanies];
GO
IF OBJECT_ID(N'[dbo].[GameOwners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GameOwners];
GO
IF OBJECT_ID(N'[dbo].[GameRegions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GameRegions];
GO
IF OBJECT_ID(N'[dbo].[Games]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Games];
GO
IF OBJECT_ID(N'[dbo].[Platforms]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Platforms];
GO
IF OBJECT_ID(N'[GameInventoryDBModelStoreContainer].[GamesForGameDevView]', 'U') IS NOT NULL
    DROP TABLE [GameInventoryDBModelStoreContainer].[GamesForGameDevView];
GO
IF OBJECT_ID(N'[GameInventoryDBModelStoreContainer].[GamesForGamePubView]', 'U') IS NOT NULL
    DROP TABLE [GameInventoryDBModelStoreContainer].[GamesForGamePubView];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CompanyRelationships'
CREATE TABLE [dbo].[CompanyRelationships] (
    [CompanyRelationshipId] int IDENTITY(1,1) NOT NULL,
    [CompanyRelationshipTypeId] int  NULL,
    [FromCompany] int  NULL,
    [ToCompany] int  NULL
);
GO

-- Creating table 'CompanyRelationshipTypes'
CREATE TABLE [dbo].[CompanyRelationshipTypes] (
    [CompanyRelationshipTypeId] int IDENTITY(1,1) NOT NULL,
    [CompanyRelationshipTypeName] varchar(max)  NOT NULL
);
GO

-- Creating table 'GameCompanies'
CREATE TABLE [dbo].[GameCompanies] (
    [GameCompanyId] int IDENTITY(1,1) NOT NULL,
    [GameCompanyName] varchar(255)  NOT NULL
);
GO

-- Creating table 'GameOwners'
CREATE TABLE [dbo].[GameOwners] (
    [GameOwnerId] int IDENTITY(1,1) NOT NULL,
    [GameOwnerName] varchar(255)  NULL,
    [OwnerUserId] int  NULL
);
GO

-- Creating table 'GameRegions'
CREATE TABLE [dbo].[GameRegions] (
    [GameRegionId] int IDENTITY(1,1) NOT NULL,
    [GameRegionName] varchar(255)  NULL
);
GO

-- Creating table 'Games'
CREATE TABLE [dbo].[Games] (
    [GameId] int IDENTITY(1,1) NOT NULL,
    [PlatformId] int  NOT NULL,
    [Title] varchar(255)  NULL,
    [DeveloperId] int  NULL,
    [RegionId] int  NULL,
    [PublisherId] int  NULL,
    [HasCase] bit  NULL,
    [HasManual] bit  NULL,
    [ModelName] varchar(255)  NULL,
    [HasAccessory] bit  NULL,
    [OwnerId] int  NULL,
    [Notes] varchar(max)  NULL
);
GO

-- Creating table 'Platforms'
CREATE TABLE [dbo].[Platforms] (
    [PlatformId] int IDENTITY(1,1) NOT NULL,
    [PlatformName] varchar(255)  NULL,
    [CompanyId] int  NOT NULL
);
GO

-- Creating table 'GamesForGameDevViews'
CREATE TABLE [dbo].[GamesForGameDevViews] (
    [GameDeveloper] varchar(255)  NOT NULL,
    [GameCount] int  NULL
);
GO

-- Creating table 'GamesForGamePubViews'
CREATE TABLE [dbo].[GamesForGamePubViews] (
    [GameDeveloper] varchar(255)  NOT NULL,
    [GameCount] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CompanyRelationshipId] in table 'CompanyRelationships'
ALTER TABLE [dbo].[CompanyRelationships]
ADD CONSTRAINT [PK_CompanyRelationships]
    PRIMARY KEY CLUSTERED ([CompanyRelationshipId] ASC);
GO

-- Creating primary key on [CompanyRelationshipTypeId] in table 'CompanyRelationshipTypes'
ALTER TABLE [dbo].[CompanyRelationshipTypes]
ADD CONSTRAINT [PK_CompanyRelationshipTypes]
    PRIMARY KEY CLUSTERED ([CompanyRelationshipTypeId] ASC);
GO

-- Creating primary key on [GameCompanyId] in table 'GameCompanies'
ALTER TABLE [dbo].[GameCompanies]
ADD CONSTRAINT [PK_GameCompanies]
    PRIMARY KEY CLUSTERED ([GameCompanyId] ASC);
GO

-- Creating primary key on [GameOwnerId] in table 'GameOwners'
ALTER TABLE [dbo].[GameOwners]
ADD CONSTRAINT [PK_GameOwners]
    PRIMARY KEY CLUSTERED ([GameOwnerId] ASC);
GO

-- Creating primary key on [GameRegionId] in table 'GameRegions'
ALTER TABLE [dbo].[GameRegions]
ADD CONSTRAINT [PK_GameRegions]
    PRIMARY KEY CLUSTERED ([GameRegionId] ASC);
GO

-- Creating primary key on [GameId] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [PK_Games]
    PRIMARY KEY CLUSTERED ([GameId] ASC);
GO

-- Creating primary key on [PlatformId] in table 'Platforms'
ALTER TABLE [dbo].[Platforms]
ADD CONSTRAINT [PK_Platforms]
    PRIMARY KEY CLUSTERED ([PlatformId] ASC);
GO

-- Creating primary key on [GameDeveloper] in table 'GamesForGameDevViews'
ALTER TABLE [dbo].[GamesForGameDevViews]
ADD CONSTRAINT [PK_GamesForGameDevViews]
    PRIMARY KEY CLUSTERED ([GameDeveloper] ASC);
GO

-- Creating primary key on [GameDeveloper] in table 'GamesForGamePubViews'
ALTER TABLE [dbo].[GamesForGamePubViews]
ADD CONSTRAINT [PK_GamesForGamePubViews]
    PRIMARY KEY CLUSTERED ([GameDeveloper] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FromCompany] in table 'CompanyRelationships'
ALTER TABLE [dbo].[CompanyRelationships]
ADD CONSTRAINT [FK_CompanyRelationship_ToFromCompany]
    FOREIGN KEY ([FromCompany])
    REFERENCES [dbo].[GameCompanies]
        ([GameCompanyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyRelationship_ToFromCompany'
CREATE INDEX [IX_FK_CompanyRelationship_ToFromCompany]
ON [dbo].[CompanyRelationships]
    ([FromCompany]);
GO

-- Creating foreign key on [ToCompany] in table 'CompanyRelationships'
ALTER TABLE [dbo].[CompanyRelationships]
ADD CONSTRAINT [FK_CompanyRelationship_ToToCompany]
    FOREIGN KEY ([ToCompany])
    REFERENCES [dbo].[GameCompanies]
        ([GameCompanyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyRelationship_ToToCompany'
CREATE INDEX [IX_FK_CompanyRelationship_ToToCompany]
ON [dbo].[CompanyRelationships]
    ([ToCompany]);
GO

-- Creating foreign key on [CompanyRelationshipTypeId] in table 'CompanyRelationships'
ALTER TABLE [dbo].[CompanyRelationships]
ADD CONSTRAINT [FK_CompanyRelationships_ToCompanyRelationshipTypes]
    FOREIGN KEY ([CompanyRelationshipTypeId])
    REFERENCES [dbo].[CompanyRelationshipTypes]
        ([CompanyRelationshipTypeId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyRelationships_ToCompanyRelationshipTypes'
CREATE INDEX [IX_FK_CompanyRelationships_ToCompanyRelationshipTypes]
ON [dbo].[CompanyRelationships]
    ([CompanyRelationshipTypeId]);
GO

-- Creating foreign key on [DeveloperId] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [FK_Games_ToGameDevCompany]
    FOREIGN KEY ([DeveloperId])
    REFERENCES [dbo].[GameCompanies]
        ([GameCompanyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Games_ToGameDevCompany'
CREATE INDEX [IX_FK_Games_ToGameDevCompany]
ON [dbo].[Games]
    ([DeveloperId]);
GO

-- Creating foreign key on [PublisherId] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [FK_Games_ToGamePubCompany]
    FOREIGN KEY ([PublisherId])
    REFERENCES [dbo].[GameCompanies]
        ([GameCompanyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Games_ToGamePubCompany'
CREATE INDEX [IX_FK_Games_ToGamePubCompany]
ON [dbo].[Games]
    ([PublisherId]);
GO

-- Creating foreign key on [CompanyId] in table 'Platforms'
ALTER TABLE [dbo].[Platforms]
ADD CONSTRAINT [FK_Platforms_ToGameCompanies]
    FOREIGN KEY ([CompanyId])
    REFERENCES [dbo].[GameCompanies]
        ([GameCompanyId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Platforms_ToGameCompanies'
CREATE INDEX [IX_FK_Platforms_ToGameCompanies]
ON [dbo].[Platforms]
    ([CompanyId]);
GO

-- Creating foreign key on [OwnerId] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [FK_Games_ToGameOwners]
    FOREIGN KEY ([OwnerId])
    REFERENCES [dbo].[GameOwners]
        ([GameOwnerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Games_ToGameOwners'
CREATE INDEX [IX_FK_Games_ToGameOwners]
ON [dbo].[Games]
    ([OwnerId]);
GO

-- Creating foreign key on [RegionId] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [FK_Games_ToGameRegions]
    FOREIGN KEY ([RegionId])
    REFERENCES [dbo].[GameRegions]
        ([GameRegionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Games_ToGameRegions'
CREATE INDEX [IX_FK_Games_ToGameRegions]
ON [dbo].[Games]
    ([RegionId]);
GO

-- Creating foreign key on [PlatformId] in table 'Games'
ALTER TABLE [dbo].[Games]
ADD CONSTRAINT [FK_Games_ToPlatforms]
    FOREIGN KEY ([PlatformId])
    REFERENCES [dbo].[Platforms]
        ([PlatformId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Games_ToPlatforms'
CREATE INDEX [IX_FK_Games_ToPlatforms]
ON [dbo].[Games]
    ([PlatformId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------