
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/19/2020 12:27:31
-- Generated from EDMX file: D:\Project\Project1\DataBaseModels.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DBSalon(lb8)];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RequestClient]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Request] DROP CONSTRAINT [FK_RequestClient];
GO
IF OBJECT_ID(N'[dbo].[FK_ServiceTypeService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Service] DROP CONSTRAINT [FK_ServiceTypeService];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeSchedule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Schedule] DROP CONSTRAINT [FK_EmployeeSchedule];
GO
IF OBJECT_ID(N'[dbo].[FK_RequestServiceRequest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequestService] DROP CONSTRAINT [FK_RequestServiceRequest];
GO
IF OBJECT_ID(N'[dbo].[FK_RequestServiceService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequestService] DROP CONSTRAINT [FK_RequestServiceService];
GO
IF OBJECT_ID(N'[dbo].[FK_RequestEmployeeEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequestEmployee] DROP CONSTRAINT [FK_RequestEmployeeEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_RequestEmployeeRequest]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[RequestEmployee] DROP CONSTRAINT [FK_RequestEmployeeRequest];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeServiceEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeService] DROP CONSTRAINT [FK_EmployeeServiceEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeServiceService]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EmployeeService] DROP CONSTRAINT [FK_EmployeeServiceService];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Client]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Client];
GO
IF OBJECT_ID(N'[dbo].[Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee];
GO
IF OBJECT_ID(N'[dbo].[Request]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Request];
GO
IF OBJECT_ID(N'[dbo].[Service]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Service];
GO
IF OBJECT_ID(N'[dbo].[TypeService]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeService];
GO
IF OBJECT_ID(N'[dbo].[Schedule]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Schedule];
GO
IF OBJECT_ID(N'[dbo].[RequestService]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RequestService];
GO
IF OBJECT_ID(N'[dbo].[RequestEmployee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[RequestEmployee];
GO
IF OBJECT_ID(N'[dbo].[EmployeeService]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EmployeeService];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Client'
CREATE TABLE [dbo].[Client] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NULL,
    [Age] int  NOT NULL,
    [Email] nvarchar(max)  NULL
);
GO

-- Creating table 'Employee'
CREATE TABLE [dbo].[Employee] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NULL,
    [Age] int  NULL,
    [Post] nvarchar(max)  NULL,
    [Email] nvarchar(max)  NULL
);
GO

-- Creating table 'Request'
CREATE TABLE [dbo].[Request] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Price] float  NULL,
    [DateStart] datetime  NULL,
    [DateFinish] datetime  NULL,
    [Session_Time] datetime  NULL,
    [ClientID] int  NOT NULL,
    [Status] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Service'
CREATE TABLE [dbo].[Service] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [TypeServiceID] int  NOT NULL
);
GO

-- Creating table 'TypeService'
CREATE TABLE [dbo].[TypeService] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NULL,
    [Description] nvarchar(max)  NULL
);
GO

-- Creating table 'Schedule'
CREATE TABLE [dbo].[Schedule] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [DateStart] datetime  NULL,
    [DateFinish] datetime  NULL,
    [EmployeeID] int  NULL
);
GO

-- Creating table 'RequestService'
CREATE TABLE [dbo].[RequestService] (
    [RequestID] int  NOT NULL,
    [ServiceID] int  NOT NULL
);
GO

-- Creating table 'RequestEmployee'
CREATE TABLE [dbo].[RequestEmployee] (
    [EmployeeID] int  NOT NULL,
    [RequestID] int  NOT NULL
);
GO

-- Creating table 'EmployeeService'
CREATE TABLE [dbo].[EmployeeService] (
    [EmployeeID] int  NOT NULL,
    [ServiceID] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ID] in table 'Client'
ALTER TABLE [dbo].[Client]
ADD CONSTRAINT [PK_Client]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Employee'
ALTER TABLE [dbo].[Employee]
ADD CONSTRAINT [PK_Employee]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Request'
ALTER TABLE [dbo].[Request]
ADD CONSTRAINT [PK_Request]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Service'
ALTER TABLE [dbo].[Service]
ADD CONSTRAINT [PK_Service]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TypeService'
ALTER TABLE [dbo].[TypeService]
ADD CONSTRAINT [PK_TypeService]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Schedule'
ALTER TABLE [dbo].[Schedule]
ADD CONSTRAINT [PK_Schedule]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [RequestID], [ServiceID] in table 'RequestService'
ALTER TABLE [dbo].[RequestService]
ADD CONSTRAINT [PK_RequestService]
    PRIMARY KEY CLUSTERED ([RequestID], [ServiceID] ASC);
GO

-- Creating primary key on [EmployeeID], [RequestID] in table 'RequestEmployee'
ALTER TABLE [dbo].[RequestEmployee]
ADD CONSTRAINT [PK_RequestEmployee]
    PRIMARY KEY CLUSTERED ([EmployeeID], [RequestID] ASC);
GO

-- Creating primary key on [EmployeeID], [ServiceID] in table 'EmployeeService'
ALTER TABLE [dbo].[EmployeeService]
ADD CONSTRAINT [PK_EmployeeService]
    PRIMARY KEY CLUSTERED ([EmployeeID], [ServiceID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClientID] in table 'Request'
ALTER TABLE [dbo].[Request]
ADD CONSTRAINT [FK_RequestClient]
    FOREIGN KEY ([ClientID])
    REFERENCES [dbo].[Client]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequestClient'
CREATE INDEX [IX_FK_RequestClient]
ON [dbo].[Request]
    ([ClientID]);
GO

-- Creating foreign key on [TypeServiceID] in table 'Service'
ALTER TABLE [dbo].[Service]
ADD CONSTRAINT [FK_ServiceTypeService]
    FOREIGN KEY ([TypeServiceID])
    REFERENCES [dbo].[TypeService]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ServiceTypeService'
CREATE INDEX [IX_FK_ServiceTypeService]
ON [dbo].[Service]
    ([TypeServiceID]);
GO

-- Creating foreign key on [EmployeeID] in table 'Schedule'
ALTER TABLE [dbo].[Schedule]
ADD CONSTRAINT [FK_EmployeeSchedule]
    FOREIGN KEY ([EmployeeID])
    REFERENCES [dbo].[Employee]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeSchedule'
CREATE INDEX [IX_FK_EmployeeSchedule]
ON [dbo].[Schedule]
    ([EmployeeID]);
GO

-- Creating foreign key on [RequestID] in table 'RequestService'
ALTER TABLE [dbo].[RequestService]
ADD CONSTRAINT [FK_RequestServiceRequest]
    FOREIGN KEY ([RequestID])
    REFERENCES [dbo].[Request]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ServiceID] in table 'RequestService'
ALTER TABLE [dbo].[RequestService]
ADD CONSTRAINT [FK_RequestServiceService]
    FOREIGN KEY ([ServiceID])
    REFERENCES [dbo].[Service]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequestServiceService'
CREATE INDEX [IX_FK_RequestServiceService]
ON [dbo].[RequestService]
    ([ServiceID]);
GO

-- Creating foreign key on [EmployeeID] in table 'RequestEmployee'
ALTER TABLE [dbo].[RequestEmployee]
ADD CONSTRAINT [FK_RequestEmployeeEmployee]
    FOREIGN KEY ([EmployeeID])
    REFERENCES [dbo].[Employee]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [RequestID] in table 'RequestEmployee'
ALTER TABLE [dbo].[RequestEmployee]
ADD CONSTRAINT [FK_RequestEmployeeRequest]
    FOREIGN KEY ([RequestID])
    REFERENCES [dbo].[Request]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RequestEmployeeRequest'
CREATE INDEX [IX_FK_RequestEmployeeRequest]
ON [dbo].[RequestEmployee]
    ([RequestID]);
GO

-- Creating foreign key on [EmployeeID] in table 'EmployeeService'
ALTER TABLE [dbo].[EmployeeService]
ADD CONSTRAINT [FK_EmployeeServiceEmployee]
    FOREIGN KEY ([EmployeeID])
    REFERENCES [dbo].[Employee]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ServiceID] in table 'EmployeeService'
ALTER TABLE [dbo].[EmployeeService]
ADD CONSTRAINT [FK_EmployeeServiceService]
    FOREIGN KEY ([ServiceID])
    REFERENCES [dbo].[Service]
        ([ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeServiceService'
CREATE INDEX [IX_FK_EmployeeServiceService]
ON [dbo].[EmployeeService]
    ([ServiceID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------