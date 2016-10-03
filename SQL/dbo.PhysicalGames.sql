CREATE TABLE [dbo].[PhysicalGames]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Box] BIT NULL, 
    [Manual] BIT NULL, 
    [Model] VARCHAR(50) NULL, 
    [Version] VARCHAR(50) NULL, 
    CONSTRAINT [FK_PhysicalGames_ToTable] FOREIGN KEY (Id) REFERENCES Games(GameId)
)
