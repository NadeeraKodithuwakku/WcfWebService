CREATE PROCEDURE [dbo].[ReadAllWorkOrders]
AS
	SELECT wo.UnitId,wo.DistributorNumber, wo.WorkOrderNumber
	FROM WorkOrder AS wo
RETURN 0
