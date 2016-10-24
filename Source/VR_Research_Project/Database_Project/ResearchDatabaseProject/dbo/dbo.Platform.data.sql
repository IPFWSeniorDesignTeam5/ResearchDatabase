SET IDENTITY_INSERT [dbo].[Platform] ON
MERGE INTO [dbo].[Platform] AS Target
USING (VALUES 
		(1, N'Gear VR'),
		(2, N'HTC Vive'),
		(3, N'Oculus Rift')
) 
AS Source (NewIdVal, [NewName])
ON Target.Id = Source.NewIdVal
WHEN NOT MATCHED BY TARGET THEN
INSERT (Id, Name) VALUES (NewIdVal, [NewName]); 
SET IDENTITY_INSERT [dbo].[Platform] OFF
