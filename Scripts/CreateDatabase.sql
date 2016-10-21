CREATE TABLE [dbo].[Genre]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] VARCHAR(250) NOT NULL
);
CREATE TABLE [dbo].[Developer]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(250) NULL
);
CREATE TABLE [dbo].[Platform] (
    [Id]   INT        NOT NULL IDENTITY,
    [Name] VARCHAR(50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[Mechanic]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Description] VARCHAR(250) NULL
);
CREATE TABLE [dbo].[Review]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Reviewer] VARCHAR(50) NOT NULL, 
    [TimeSpent] INT NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [MechanicsDescription] VARCHAR(MAX) NULL
);
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
CREATE TABLE [dbo].[ApplicationGenre]
(
	[ApplicationId] INT NOT NULL , 
    [GenreId] INT NOT NULL, 
    PRIMARY KEY ([ApplicationId], [GenreId]), 
    CONSTRAINT [FK_ApplicationGenre_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [Application]([Id]), 
    CONSTRAINT [FK_ApplicationGenre_ToGenre] FOREIGN KEY ([GenreId]) REFERENCES [Genre]([Id])
);
CREATE TABLE [dbo].[ApplicationMechanic]
(
    [ApplicationId] INT NOT NULL , 
    [MechanicId] INT NOT NULL, 
    PRIMARY KEY ([ApplicationId], [MechanicId]), 
    CONSTRAINT [FK_ApplicationMechanic_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [Application]([Id]), 
    CONSTRAINT [FK_ApplicationMechanic_ToMechanic] FOREIGN KEY ([MechanicId]) REFERENCES [Mechanic]([Id])
);
CREATE TABLE [dbo].[ApplicationReview]
(
	[ApplicationId] INT NOT NULL , 
    [ReviewId] INT NOT NULL, 
    PRIMARY KEY ([ReviewId], [ApplicationId]), 
    CONSTRAINT [FK_ApplicationReview_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [Application]([Id]), 
    CONSTRAINT [FK_ApplicationReview_ToReview] FOREIGN KEY ([ReviewId]) REFERENCES [Review]([Id])
);
SET IDENTITY_INSERT [dbo].[Genre] ON
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (1, N'360-Degree Video')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (2, N'Game')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (3, N'Racing Simulator')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (4, N'Roleplaying')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (5, N'Non-Interactive')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (6, N'Interactive')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (7, N'Horror')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (8, N'Flight Simulator')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (9, N'Strategy')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (10, N'Shooter')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (11, N'Retail Tool')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (12, N'Puzzle')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (13, N'Educational')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (14, N'Multiplayer')
INSERT INTO [dbo].[Genre] ([Id], [Description]) VALUES (15, N'Industrial Tool')
SET IDENTITY_INSERT [dbo].[Genre] OFF
SET IDENTITY_INSERT [dbo].[Platform] ON
INSERT INTO [dbo].[Platform] ([Id], [Name]) VALUES (1, N'Gear VR')
INSERT INTO [dbo].[Platform] ([Id], [Name]) VALUES (2, N'HTC Vive')
INSERT INTO [dbo].[Platform] ([Id], [Name]) VALUES (3, N'Oculus Rift')
SET IDENTITY_INSERT [dbo].[Platform] OFF
SET IDENTITY_INSERT [dbo].[Mechanic] ON
INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (3, N'Teleport Movement')
INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (4, N'3D Sound')
INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (5, N'Item Use')
INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (6, N'Joypad Movement')
INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (7, N'Object/Physics Interaction')
INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (8, N'Projectile Use')
INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (9, N'Gaze Movement')
INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (10, N'Subtitle Text')
INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (11, N'Static UI (HUD)')
INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (12, N'Augmented Reality')
SET IDENTITY_INSERT [dbo].[Mechanic] OFF
