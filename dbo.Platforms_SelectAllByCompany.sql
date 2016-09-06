CREATE PROCEDURE [dbo].Platforms_SelectAllByCompany
	@companyId int = 0
AS
	SELECT p.PlatformName as PlatformName,
           p.PlatformId as PlatformId
    FROM dbo.Platforms p
    WHERE p.CompanyId = @companyId
