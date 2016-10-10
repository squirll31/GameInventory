CREATE TABLE [dbo].[DigtialGames] (
    [DigitalGameId]        INT NOT NULL,
    [ServiceId] INT NOT NULL,
    [GameId] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([DigitalGameId] ASC), 
    CONSTRAINT [FK_DigtialGames_Games] FOREIGN KEY ([GameId]) REFERENCES [dbo].[Games]([GameId]), 
    CONSTRAINT [FK_DigtialGames_ToTable] FOREIGN KEY ([ServiceId]) REFERENCES [dbo].[DigitalService]([DigitalServiceId])
);

