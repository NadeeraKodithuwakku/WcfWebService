CREATE PROCEDURE [dbo].[AddWorkOrderDetails]
	@distributorNumber varchar(50),
	@workOrderNumber varchar(50)
AS
	INSERT INTO WorkOrder(DistributorNumber,WorkOrderNumber) VALUES(@distributorNumber, @workOrderNumber);
RETURN 0
