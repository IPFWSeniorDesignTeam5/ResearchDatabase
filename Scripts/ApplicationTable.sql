CREATE TABLE [dbo].[Application] (
    [Id]          INT           NOT NULL IDENTITY,
    [Name]        VARCHAR (250) NULL,
    [DeveloperId] INT           NOT NULL,
    [ReleaseDate] DATE          NULL,
    [Platform]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Application_ToDeveloper] FOREIGN KEY ([DeveloperId]) REFERENCES [dbo].[Developer] ([Id]), 
    CONSTRAINT [FK_Application_ToPlatform] FOREIGN KEY ([Platform]) REFERENCES [Platform]([Id])
);

