
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/15/2019 13:37:26
-- Generated from EDMX file: C:\Users\Dmitrii\source\repos\Rab_BD_Code FirstV2\Rab_BD_Database FirstV2\User.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [usersdb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO
IF OBJECT_ID(N'[dbo].[PhoneSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhoneSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Age] nvarchar(max)  NOT NULL,
    [Adress] nvarchar(max)  NOT NULL,
    [PKI] nvarchar(max)  NOT NULL,
    [Coment] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PhoneSet'
CREATE TABLE [dbo].[PhoneSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NameT] nvarchar(max)  NOT NULL,
    [Price] nvarchar(max)  NOT NULL,
    [Opisanie] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
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