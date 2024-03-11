USE [MyBlogDb_Dev03]
GO
select GETDATE()
select DATEDIFF(year,DateAndTime,GETDATE()) from users
/****** Object: Table [dbo].[users] Script Date: 2/15/2024 11:42:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Email]       NVARCHAR (MAX) NOT NULL,
    [Islocked]    BIT            NOT NULL,
    [Age]         TINYINT        NOT NULL,
    [Gender]      TINYINT        NOT NULL,
    [Rool]        INT            NOT NULL,
    [DateAndTime] DATETIME2 (7)  NOT NULL,
    [Photo]       BINARY (8000)  NOT NULL
);


