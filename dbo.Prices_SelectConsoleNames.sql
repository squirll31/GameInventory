CREATE PROCEDURE dbo.Prices_SelectConsoleNames
AS
BEGIN
	SELECT DISTINCT
		p.ConsoleName as ConsoleName
	FROM dbo.Prices_09Oct16 p
	ORDER BY p.ConsoleName ASC
END