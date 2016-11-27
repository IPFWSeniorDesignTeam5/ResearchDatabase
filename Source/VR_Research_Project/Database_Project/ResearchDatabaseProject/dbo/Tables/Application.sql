CREATE TABLE [dbo].[Application] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (250) NULL,
    [DeveloperId] INT           NOT NULL,
    [ReleaseDate] DATE          NOT NULL,
    [Platform]    INT           NOT NULL,
    [GeneralDescription] VARCHAR(550) NULL, 
    [MechanicDescription] VARCHAR(550) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Application_ToDeveloper] FOREIGN KEY ([DeveloperId]) REFERENCES [dbo].[Developer] ([Id]),
    CONSTRAINT [FK_Application_ToPlatform] FOREIGN KEY ([Platform]) REFERENCES [dbo].[Platform] ([Id])
);

