CREATE TABLE [dbo].[ApplicationGenre]
(
	[ApplicationId] INT NOT NULL , 
    [GenreId] INT NOT NULL, 
    PRIMARY KEY ([ApplicationId], [GenreId]), 
    CONSTRAINT [FK_ApplicationGenre_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [Application]([Id]), 
    CONSTRAINT [FK_ApplicationGenre_ToGenre] FOREIGN KEY ([GenreId]) REFERENCES [Genre]([Id])
)
