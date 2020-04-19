USE [BloodDonation]
GO

/****** Object: Table [dbo].[Users] Script Date: 20-04-2020 1.16.44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Users] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [First_Name]  NVARCHAR (250) NOT NULL,
    [Last_Name]   NCHAR (250)    NOT NULL,
    [Address]     NVARCHAR (MAX) NOT NULL,
    [Gender]      NCHAR (10)     NOT NULL,
    [Phone]       NVARCHAR (50)  NOT NULL,
    [Password]    NVARCHAR (MAX) NOT NULL,
    [Email]       NVARCHAR (MAX) NOT NULL,
    [Age]         INT            NOT NULL,
    [User_Type]   NCHAR (10)     NOT NULL,
    [Postal_Code] NVARCHAR (50)  NOT NULL,
    [DOB]         DATE           NOT NULL
);


