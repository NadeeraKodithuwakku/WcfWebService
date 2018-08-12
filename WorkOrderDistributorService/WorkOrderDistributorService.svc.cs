using DistributorService.Core;
using Shared;
using Shared.Entities;
using Unity;
using WorkOrderDistributorService.Validation;

namespace WorkOrderDistributorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WorkOrderDistributorService : IWorkOrderDistributorService
    {
        private readonly IWorkOrderManager workOrderManager;

        public WorkOrderDistributorService()
        {
            workOrderManager = IoCContainer.Container.Resolve<IWorkOrderManager>();
        }
       
        public WorkOrderResponse SaveWorkOrder(WorkOrderRequest workOrderRequest)
        {
            var details = workOrderRequest.WorkOrderDetails;
            var response = new WorkOrderResponse();

            var isValidDistributorNumber = WorkOrderDetailsValidation.IsValidDistibutorNumber(details.DistributorNumber);
            var isValidWorkOrderNumber = WorkOrderDetailsValidation.IsValidWorkOrderNumber(details.WorkOrderNumber);

            if(isValidDistributorNumber)
            {
                if (isValidWorkOrderNumber)
                {
                    response.Status = Status.SAVED_SUCCESS;
                    //insert to DB
                }
                else
                {
                    response.Status = Status.WORK_ORDER_IS_REQUIRED;
                }
            }
            else
            {
                response.Status = Status.DISTRIBUTOR_IS_REQUIRED;
            }
            return response;
        }

    }
}
