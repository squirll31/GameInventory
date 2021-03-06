﻿CREATE PROCEDURE [dbo].[Games_SelectAllForPublisher]
	@companyId int = 0
AS
    DECLARE @pubName varchar(255) = (SELECT c.GameCompanyId FROM dbo.GameCompanies c WHERE c.GameCompanyId = @companyId);

	SELECT g.GameId as GameId,
           g.DeveloperId as DeveloperId,
           gc2.GameCompanyName as DeveloperName,
           g.HasAccessory as HasAccessory,
           g.HasCase as HasCase,
           g.HasManual as HasManual,
           g.ModelName as ModelName,
           g.Notes as Notes,
           g.OwnerId as OwnerId,
           ow.GameOwnerName as OwnerName,
           g.PlatformId as PlatformId,
           pl.PlatformName as PlatformName,
           g.PublisherId as PublisherId,
           @pubName as PublisherName,
           g.RegionId as RegionId,
           re.GameRegionName as RegionName,
           g.Title as Title
    FROM dbo.Games g
        JOIN dbo.GameCompanies gc2 ON gc2.GameCompanyId = g.DeveloperId
        JOIN dbo.Platforms pl ON pl.PlatformId = g.PlatformId
        JOIN dbo.GameRegions re ON re.GameRegionId = g.RegionId
        JOIN dbo.GameOwners ow ON ow.GameOwnerId = g.OwnerId
    WHERE g.PublisherId = @companyId