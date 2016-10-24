CREATE TABLE [dbo].[Review] (
    [Id]                   INT           IDENTITY (1, 1) NOT NULL,
    [Reviewer]             VARCHAR (50)  NOT NULL,
    [TimeSpent]            INT           NULL,
    [Description]          VARCHAR (MAX) NULL,
    [MechanicsDescription] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

