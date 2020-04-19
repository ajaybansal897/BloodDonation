USE [BloodDonation]
GO

/****** Object: Table [dbo].[Centers] Script Date: 20-04-2020 1.16.23 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Centers] (
    [Id]      INT            IDENTITY (1, 1) NOT NULL,
    [Address] NVARCHAR (MAX) NOT NULL
);


