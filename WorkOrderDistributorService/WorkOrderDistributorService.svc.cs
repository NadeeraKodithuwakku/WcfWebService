﻿using DistributorService.Core;
using Shared;
using Shared.Entities;
using Unity;
using WorkOrderData;
using WorkOrderDistributorService.Validation;

namespace WorkOrderDistributorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WorkOrderDistributorService : IWorkOrderDistributorService
    {
        private readonly IWorkOrderManager workOrderManager;
        private readonly IDatabaseManager databaseManager;

        public WorkOrderDistributorService()
        {
            workOrderManager = IoCContainer.Container.Resolve<IWorkOrderManager>();
            databaseManager = IoCContainer.Container.Resolve<IDatabaseManager>();
        }
       
        public WorkOrderResponse SaveWorkOrder(WorkOrderRequest workOrderRequest)
        {
            var response = new WorkOrderResponse();
            var validations = this.workOrderManager.ValidateWorkOrder(workOrderRequest);

            if (validations.Count > 0)
            {
                response.ValidationErrors = validations;
                response.Status = Status.FAILED_SAVING_ORDER;
            }
            else
            {
                databaseManager.AddWorkDetails(workOrderRequest.WorkOrderDetails);
                response.Status = Status.SAVED_SUCCESS;
            }

           
            return response;
        }

    }
}
