CREATE PROCEDURE [dbo].[GetPhysicalGameById]
	@id int = 0
AS
	SELECT 
		pg.Id as Id,
		pg.Box as Box,
		pg.Manual as Manual,
		pg.Model as Model,
		pg.Version as Version
	FROM PhysicalGames pg
	WHERE pg.Id = @id
RETURN 0
