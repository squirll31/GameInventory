IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[RecentGames]'))
DROP VIEW [dbo].[RecentGames]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[RecentGames]
	AS SELECT TOP 5 * FROM [Games] g ORDER BY g.GameId DESC; 