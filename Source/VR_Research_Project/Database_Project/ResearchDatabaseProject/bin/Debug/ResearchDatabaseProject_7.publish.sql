﻿/*
Deployment script for ResearchDatabase_TEST

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "ResearchDatabase_TEST"
:setvar DefaultFilePrefix "ResearchDatabase_TEST"
:setvar DefaultDataPath "C:\Users\DanJa\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"
:setvar DefaultLogPath "C:\Users\DanJa\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"

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
USE [master];


GO

IF (DB_ID(N'$(DatabaseName)') IS NOT NULL) 
BEGIN
    ALTER DATABASE [$(DatabaseName)]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [$(DatabaseName)];
END

GO
PRINT N'Creating $(DatabaseName)...'
GO
CREATE DATABASE [$(DatabaseName)]
    ON 
    PRIMARY(NAME = [$(DatabaseName)], FILENAME = N'$(DefaultDataPath)$(DefaultFilePrefix)_Primary.mdf')
    LOG ON (NAME = [$(DatabaseName)_log], FILENAME = N'$(DefaultLogPath)$(DefaultFilePrefix)_Primary.ldf') COLLATE SQL_Latin1_General_CP1_CI_AS
GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ANSI_NULLS ON,
                ANSI_PADDING ON,
                ANSI_WARNINGS ON,
                ARITHABORT ON,
                CONCAT_NULL_YIELDS_NULL ON,
                NUMERIC_ROUNDABORT OFF,
                QUOTED_IDENTIFIER ON,
                ANSI_NULL_DEFAULT ON,
                CURSOR_DEFAULT LOCAL,
                CURSOR_CLOSE_ON_COMMIT OFF,
                AUTO_CREATE_STATISTICS ON,
                AUTO_SHRINK OFF,
                AUTO_UPDATE_STATISTICS ON,
                RECURSIVE_TRIGGERS OFF 
            WITH ROLLBACK IMMEDIATE;
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CLOSE OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET ALLOW_SNAPSHOT_ISOLATION OFF;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET READ_COMMITTED_SNAPSHOT OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_UPDATE_STATISTICS_ASYNC OFF,
                PAGE_VERIFY NONE,
                DATE_CORRELATION_OPTIMIZATION OFF,
                DISABLE_BROKER,
                PARAMETERIZATION SIMPLE,
                SUPPLEMENTAL_LOGGING OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET TRUSTWORTHY OFF,
        DB_CHAINING OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
IF IS_SRVROLEMEMBER(N'sysadmin') = 1
    BEGIN
        IF EXISTS (SELECT 1
                   FROM   [master].[dbo].[sysdatabases]
                   WHERE  [name] = N'$(DatabaseName)')
            BEGIN
                EXECUTE sp_executesql N'ALTER DATABASE [$(DatabaseName)]
    SET HONOR_BROKER_PRIORITY OFF 
    WITH ROLLBACK IMMEDIATE';
            END
    END
ELSE
    BEGIN
        PRINT N'The database settings cannot be modified. You must be a SysAdmin to apply these settings.';
    END


GO
ALTER DATABASE [$(DatabaseName)]
    SET TARGET_RECOVERY_TIME = 0 SECONDS 
    WITH ROLLBACK IMMEDIATE;


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF),
                CONTAINMENT = NONE 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET AUTO_CREATE_STATISTICS ON(INCREMENTAL = OFF),
                MEMORY_OPTIMIZED_ELEVATE_TO_SNAPSHOT = OFF,
                DELAYED_DURABILITY = DISABLED 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE (QUERY_CAPTURE_MODE = ALL, FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_PLANS_PER_QUERY = 200, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 367), MAX_STORAGE_SIZE_MB = 100) 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE [$(DatabaseName)]
            SET QUERY_STORE = OFF 
            WITH ROLLBACK IMMEDIATE;
    END


GO
IF EXISTS (SELECT 1
           FROM   [master].[dbo].[sysdatabases]
           WHERE  [name] = N'$(DatabaseName)')
    BEGIN
        ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
        ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
        ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
    END


GO
USE [$(DatabaseName)];


GO
IF fulltextserviceproperty(N'IsFulltextInstalled') = 1
    EXECUTE sp_fulltext_database 'enable';


GO
PRINT N'Creating [dbo].[Application]...';


GO
CREATE TABLE [dbo].[Application] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        VARCHAR (250) NULL,
    [DeveloperId] INT           NOT NULL,
    [ReleaseDate] DATE          NULL,
    [Platform]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[ApplicationGenre]...';


GO
CREATE TABLE [dbo].[ApplicationGenre] (
    [ApplicationId] INT NOT NULL,
    [GenreId]       INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ApplicationId] ASC, [GenreId] ASC)
);


GO
PRINT N'Creating [dbo].[ApplicationMechanic]...';


GO
CREATE TABLE [dbo].[ApplicationMechanic] (
    [ApplicationId] INT NOT NULL,
    [MechanicId]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ApplicationId] ASC, [MechanicId] ASC)
);


GO
PRINT N'Creating [dbo].[ApplicationReview]...';


GO
CREATE TABLE [dbo].[ApplicationReview] (
    [ApplicationId] INT NOT NULL,
    [ReviewId]      INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ReviewId] ASC, [ApplicationId] ASC)
);


GO
PRINT N'Creating [dbo].[Developer]...';


GO
CREATE TABLE [dbo].[Developer] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Genre]...';


GO
CREATE TABLE [dbo].[Genre] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Mechanic]...';


GO
CREATE TABLE [dbo].[Mechanic] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (250) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Platform]...';


GO
CREATE TABLE [dbo].[Platform] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[Review]...';


GO
CREATE TABLE [dbo].[Review] (
    [Id]                   INT           IDENTITY (1, 1) NOT NULL,
    [Reviewer]             VARCHAR (50)  NOT NULL,
    [TimeSpent]            INT           NULL,
    [Description]          VARCHAR (MAX) NULL,
    [MechanicsDescription] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
PRINT N'Creating [dbo].[FK_Application_ToDeveloper]...';


GO
ALTER TABLE [dbo].[Application]
    ADD CONSTRAINT [FK_Application_ToDeveloper] FOREIGN KEY ([DeveloperId]) REFERENCES [dbo].[Developer] ([Id]);


GO
PRINT N'Creating [dbo].[FK_Application_ToPlatform]...';


GO
ALTER TABLE [dbo].[Application]
    ADD CONSTRAINT [FK_Application_ToPlatform] FOREIGN KEY ([Platform]) REFERENCES [dbo].[Platform] ([Id]);


GO
PRINT N'Creating [dbo].[FK_ApplicationGenre_ToApplication]...';


GO
ALTER TABLE [dbo].[ApplicationGenre]
    ADD CONSTRAINT [FK_ApplicationGenre_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [dbo].[Application] ([Id]);


GO
PRINT N'Creating [dbo].[FK_ApplicationGenre_ToGenre]...';


GO
ALTER TABLE [dbo].[ApplicationGenre]
    ADD CONSTRAINT [FK_ApplicationGenre_ToGenre] FOREIGN KEY ([GenreId]) REFERENCES [dbo].[Genre] ([Id]);


GO
PRINT N'Creating [dbo].[FK_ApplicationMechanic_ToApplication]...';


GO
ALTER TABLE [dbo].[ApplicationMechanic]
    ADD CONSTRAINT [FK_ApplicationMechanic_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [dbo].[Application] ([Id]);


GO
PRINT N'Creating [dbo].[FK_ApplicationMechanic_ToMechanic]...';


GO
ALTER TABLE [dbo].[ApplicationMechanic]
    ADD CONSTRAINT [FK_ApplicationMechanic_ToMechanic] FOREIGN KEY ([MechanicId]) REFERENCES [dbo].[Mechanic] ([Id]);


GO
PRINT N'Creating [dbo].[FK_ApplicationReview_ToApplication]...';


GO
ALTER TABLE [dbo].[ApplicationReview]
    ADD CONSTRAINT [FK_ApplicationReview_ToApplication] FOREIGN KEY ([ApplicationId]) REFERENCES [dbo].[Application] ([Id]);


GO
PRINT N'Creating [dbo].[FK_ApplicationReview_ToReview]...';


GO
ALTER TABLE [dbo].[ApplicationReview]
    ADD CONSTRAINT [FK_ApplicationReview_ToReview] FOREIGN KEY ([ReviewId]) REFERENCES [dbo].[Review] ([Id]);


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
GO

GO
DECLARE @VarDecimalSupported AS BIT;

SELECT @VarDecimalSupported = 0;

IF ((ServerProperty(N'EngineEdition') = 3)
    AND (((@@microsoftversion / power(2, 24) = 9)
          AND (@@microsoftversion & 0xffff >= 3024))
         OR ((@@microsoftversion / power(2, 24) = 10)
             AND (@@microsoftversion & 0xffff >= 1600))))
    SELECT @VarDecimalSupported = 1;

IF (@VarDecimalSupported > 0)
    BEGIN
        EXECUTE sp_db_vardecimal_storage_format N'$(DatabaseName)', 'ON';
    END


GO
PRINT N'Update complete.';


GO
