CREATE VIEW [dbo].[RecentGames]
	AS SELECT TOP 5 * FROM [Games] g ORDER BY g.GameId DESC; 