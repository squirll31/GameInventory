CREATE PROCEDURE [dbo].[GetPlatformById]
	@id int = 0
AS
BEGIN
	SELECT 
		p.CompanyId as CompanyId,
		p.PlatformName as Title
	FROM Platforms p
	WHERE p.PlatformId = @id
END