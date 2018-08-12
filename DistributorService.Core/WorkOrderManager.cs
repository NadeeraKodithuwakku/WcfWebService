using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkOrderDistributorService.Validation;

namespace DistributorService.Core
{
    public class WorkOrderManager : IWorkOrderManager
    {
        public List<ValidationError> ValidateWorkOrder(WorkOrderRequest request)
        {
            List<ValidationError> validations = new List<ValidationError>();
            var isValidDistributorNumber = WorkOrderDetailsValidation.IsValidDistibutorNumber(request.WorkOrderDetails.DistributorNumber);
            var isValidWorkOrderNumber = WorkOrderDetailsValidation.IsValidWorkOrderNumber(request.WorkOrderDetails.WorkOrderNumber);

            
            return validations;
        }
    }
}
