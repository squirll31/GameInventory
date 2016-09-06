CREATE VIEW [dbo].[RecentGamesView]
	AS SELECT TOP 5 * FROM [Games] g ORDER BY g.GameId DESC; 
