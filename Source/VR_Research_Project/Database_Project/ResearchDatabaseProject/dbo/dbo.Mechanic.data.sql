--SET IDENTITY_INSERT [dbo].[Mechanic] ON
--INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (3, N'Teleport Movement')
--INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (4, N'3D Sound')
--INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (5, N'Item Use')
--INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (6, N'Joypad Movement')
--INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (7, N'Object/Physics Interaction')
--INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (8, N'Projectile Use')
--INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (9, N'Gaze Movement')
--INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (10, N'Subtitle Text')
--INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (11, N'Static UI (HUD)')
--INSERT INTO [dbo].[Mechanic] ([Id], [Description]) VALUES (12, N'Augmented Reality')
--SET IDENTITY_INSERT [dbo].[Mechanic] OFF

SET IDENTITY_INSERT [dbo].[Mechanic] ON
MERGE INTO [dbo].[Mechanic] AS Target
USING (VALUES 
		(3, N'Teleport Movement'), 
		(4, N'3D Sound'), 
		(5, N'Item Use'),
		(6, N'Joypad Movement'),
		(7, N'Object/Physics Interaction'),
		(8, N'Projectile Use'),
		(9, N'Gaze Movement'),
		(10, N'Subtitle Text'),
		(11, N'Static UI (HUD)'),
		(12, N'Augmented Reality') ) 
AS Source (NewIdVal, NewDescription)
ON Target.Id = Source.NewIdVal
WHEN NOT MATCHED BY TARGET THEN
INSERT (Id, [Description]) VALUES (NewIdVal, NewDescription); 
SET IDENTITY_INSERT [dbo].[Mechanic] OFF