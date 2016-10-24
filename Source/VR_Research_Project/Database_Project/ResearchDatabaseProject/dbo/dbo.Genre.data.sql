SET IDENTITY_INSERT [dbo].[Genre] ON
MERGE INTO [dbo].[Genre] AS Target
USING (VALUES 
		(1, N'360-Degree Video'),
		(2, N'Game'),
		(3, N'Racing Simulator'),
		(4, N'Roleplaying'),
		(5, N'Non-Interactive'),
		(6, N'Interactive'),
		(7, N'Horror'),
		(8, N'Flight Simulator'),
		(9, N'Strategy'),
		(10, N'Shooter'),
		(11, N'Retail Tool'),
		 (12, N'Puzzle'),
		 (13, N'Educational'),
		 (14, N'Multiplayer'),
		 (15, N'Industrial Tool')) 
AS Source (NewIdVal, NewDescription)
ON Target.Id = Source.NewIdVal
WHEN NOT MATCHED BY TARGET THEN
INSERT (Id, [Description]) VALUES (NewIdVal, NewDescription); 
SET IDENTITY_INSERT [dbo].[Genre] OFF
