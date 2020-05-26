﻿CREATE TABLE [dbo].[Purchase_Order_Lineitems] (
    [Purchase Order Number] NVARCHAR (255) NULL,
    [Line Number]           FLOAT (53)     NULL,
    [Item Number]           NVARCHAR (255) NULL,
    [Drawing]               NVARCHAR (255) NULL,
    [Stock Item Number]     NVARCHAR (255) NULL,
    [Quantity]              FLOAT (53)     NULL,
    [Unit of Measure]       NVARCHAR (255) NULL,
    [Tax1_but]              BIT            NOT NULL,
    [Tax2_but]              BIT            NOT NULL,
    [Qty Recvd]             FLOAT (53)     NULL,
    [Date Expec]            NVARCHAR (255) NULL,
    [Date Recvd]            NVARCHAR (255) NULL,
    [Description]           NVARCHAR (255) NULL,
    [Sub Category]          NVARCHAR (255) NULL,
    [Manufacturer data]     NVARCHAR (255) NULL,
    [Price]                 FLOAT (53)     NULL,
    [Received]              BIT            NOT NULL,
    [Comment]               NVARCHAR (255) NULL,
    [Serial Number]         NVARCHAR (255) NULL,
    [Color]                 NVARCHAR (255) NULL,
    [Size]                  NVARCHAR (255) NULL,
    [Line Note]             NVARCHAR (255) NULL,
    [Job Number]            NVARCHAR (255) NULL,
    [Qty Recvd Now]         NVARCHAR (255) NULL
);

