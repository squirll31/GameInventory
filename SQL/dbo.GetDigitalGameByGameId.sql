CREATE PROCEDURE [dbo].[GetDigitalGameByGameId]
	@id int = 0
AS
BEGIN
	SELECT
		dg.GameId,
		dg.DigitalGameId,
		dg.ServiceId,
		ds.DigitalServiceId
	FROM [dbo].[DigtialGames] dg
	JOIN [dbo].DigitalService ds
		ON ds.DigitalServiceId = dg.ServiceId
	WHERE dg.GameId = @id
END
