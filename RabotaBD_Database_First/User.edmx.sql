
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/15/2019 12:56:56
-- Generated from EDMX file: C:\Users\Dmitrii\source\repos\Rab_BD_Code FirstV2\RabotaBD_Database_First\User.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [userstoredb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Table]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Table];
GO
IF OBJECT_ID(N'[dbo].[User]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Table'
CREATE TABLE [dbo].[Table] (
    [Id] int  NOT NULL,
    [Name] nvarchar(50)  NULL,
    [Age] int  NULL
);
GO

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int  NOT NULL,
    [Name] nvarchar(50)  NULL,
    [Age] nvarchar(50)  NULL
);
GO

-- Creating table 'PhoneSet'
CREATE TABLE [dbo].[PhoneSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameT] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Table'
ALTER TABLE [dbo].[Table]
ADD CONSTRAINT [PK_Table]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PhoneSet'
ALTER TABLE [dbo].[PhoneSet]
ADD CONSTRAINT [PK_PhoneSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------