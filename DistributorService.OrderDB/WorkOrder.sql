﻿CREATE TABLE [dbo].[WorkOrder]
(
	[UnitId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DistributorNumber] VARCHAR(50) NULL, 
    [WorkOrderNumber] VARCHAR(50) NULL
)
