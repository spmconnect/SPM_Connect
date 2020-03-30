﻿CREATE TABLE [dbo].[WO_Tracking] (
    [WO]             INT          NOT NULL,
    [Engin]          INT          CONSTRAINT [DF_WO_Tracking_ChkinEng] DEFAULT ((0)) NOT NULL,
    [EngWho]         VARCHAR (50) NULL,
    [EngWhen]        DATETIME     NULL,
    [Ctrlin]         INT          CONSTRAINT [DF_WO_Tracking_Ctlrin] DEFAULT ((0)) NOT NULL,
    [CtrlWho]        VARCHAR (50) NULL,
    [CtrlWhen]       DATETIME     NULL,
    [Prodin]         INT          CONSTRAINT [DF_WO_Tracking_ChkinProd] DEFAULT ((0)) NOT NULL,
    [ProdinWho]      VARCHAR (50) NULL,
    [ProdinWhen]     DATETIME     NULL,
    [Prodout]        INT          CONSTRAINT [DF_WO_Tracking_ChkoutProd] DEFAULT ((0)) NOT NULL,
    [ProdoutWho]     VARCHAR (50) NULL,
    [ProdoutWhen]    DATETIME     NULL,
    [TimeInProd]     VARCHAR (50) CONSTRAINT [DF_WO_Tracking_TimeInProd] DEFAULT ((0)) NULL,
    [Purin]          INT          CONSTRAINT [DF_WO_Tracking_ChkinPur] DEFAULT ((0)) NOT NULL,
    [PurinWho]       VARCHAR (50) NULL,
    [PurinWhen]      DATETIME     NULL,
    [Purout]         INT          CONSTRAINT [DF_WO_Tracking_ChkoutPur] DEFAULT ((0)) NOT NULL,
    [PuroutWho]      VARCHAR (50) NULL,
    [PuroutWhen]     DATETIME     NULL,
    [TimeInPur]      VARCHAR (50) CONSTRAINT [DF_WO_Tracking_TimeInPur] DEFAULT ((0)) NULL,
    [Cribin]         INT          CONSTRAINT [DF_WO_Tracking_ChkinCrib] DEFAULT ((0)) NOT NULL,
    [CribinWho]      VARCHAR (50) NULL,
    [CribinWhen]     DATETIME     NULL,
    [Cribout]        INT          CONSTRAINT [DF_WO_Tracking_ChkoutCrib] DEFAULT ((0)) NOT NULL,
    [CriboutWho]     VARCHAR (50) NULL,
    [CriboutWhen]    DATETIME     NULL,
    [TimeInCrib]     VARCHAR (50) CONSTRAINT [DF_WO_Tracking_TimeInCrib] DEFAULT ((0)) NULL,
    [Status]         VARCHAR (50) NULL,
    [TotalTimeSpent] VARCHAR (50) CONSTRAINT [DF_WO_Tracking_TotalTimeSpent] DEFAULT ((0)) NULL,
    CONSTRAINT [PK_WO_Tracking] PRIMARY KEY CLUSTERED ([WO] ASC)
);
