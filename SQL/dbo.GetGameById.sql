CREATE PROCEDURE [dbo].[GetGameById]
	@id int = 0
AS
BEGIN
	SELECT 
		g.GameId as Id,
		g.Title as Title,
		g.PlatformId as PlatformId
	FROM Games g
	WHERE g.GameId = @id
END