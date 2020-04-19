USE [BloodDonation]
GO

/****** Object: Table [dbo].[Bookings] Script Date: 20-04-2020 1.16.13 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Bookings] (
    [Id]        INT      IDENTITY (100000, 1) NOT NULL,
    [User_id]   INT      NOT NULL,
    [Center_id] INT      NOT NULL,
    [Timing]    DATETIME NOT NULL
);


