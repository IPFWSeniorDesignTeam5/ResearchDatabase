CREATE TABLE [dbo].[Review]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Reviewer] VARCHAR(50) NOT NULL, 
    [TimeSpent] INT NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [MechanicsDescription] VARCHAR(MAX) NULL
)
