CREATE TABLE [dbo].[Review] (
    [Id]                   INT           IDENTITY (1, 1) NOT NULL,
    [Reviewer]             VARCHAR (50)  NOT NULL,
    [TimeSpent]            INT           NULL,
    [Rating] INT NOT NULL, 
    [BottomLine] VARCHAR(500) NOT NULL, 
    [ReviewDate] DATE NOT NULL DEFAULT getdate(), 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

