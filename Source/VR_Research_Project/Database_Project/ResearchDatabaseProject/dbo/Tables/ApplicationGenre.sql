CREATE TABLE [dbo].[ApplicationGenre] (
    [ApplicationId] INT NOT NULL,
    [GenreId]       INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ApplicationId] ASC, [GenreId] ASC),
    CONSTRAINT [FK_ApplicationGenre_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [dbo].[Application] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_ApplicationGenre_ToGenre] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genre] ([Id]) ON DELETE CASCADE
);

