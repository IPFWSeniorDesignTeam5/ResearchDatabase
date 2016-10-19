CREATE TABLE [dbo].[Application]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] VARCHAR(250) NULL, 
    [DeveloperId] INT NOT NULL, 
    [ReleaseDate] DATE NULL, 
    [Device] INT NOT NULL
)
