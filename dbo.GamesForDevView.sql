CREATE VIEW [dbo].[GamesForGameDevView]
	AS	
		SELECT  gc.GameCompanyName as GameDeveloper,
				Count(g.GameId) as GameCount
		FROM dbo.Games g
			JOIN dbo.GameCompanies gc on g.DeveloperId = gc.GameCompanyId
		GROUP BY g.DeveloperId
		