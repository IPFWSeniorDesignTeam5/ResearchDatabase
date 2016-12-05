﻿/*
Deployment script for ResearchDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "ResearchDatabase"
:setvar DefaultFilePrefix "ResearchDatabase"
:setvar DefaultDataPath "C:\Users\Johns\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"
:setvar DefaultLogPath "C:\Users\Johns\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [dbo].[VW_Mechanics]...';


GO
CREATE VIEW [dbo].[VW_Mechanics]
	AS SELECT Mechanic.Description,
			  COUNT(am.MechanicId) AS Relations
			  FROM
			  dbo.ApplicationMechanic am JOIN Mechanic ON am.MechanicId = Mechanic.Id
			  GROUP BY Mechanic.Description;
GO
/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

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

GO

GO
PRINT N'Update complete.';


GO
