using Shared;
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

            if (!isValidDistributorNumber)
                validations.Add(new ValidationError() { Field = nameof(request.WorkOrderDetails.DistributorNumber), ValidationType = ValidationType.REQUIRED, ValidationMessage = Status.DISTRIBUTOR_IS_REQUIRED });

            if (!isValidWorkOrderNumber)
                validations.Add(new ValidationError() { Field = nameof(request.WorkOrderDetails.WorkOrderNumber), ValidationType = ValidationType.REQUIRED, ValidationMessage = Status.WORK_ORDER_IS_REQUIRED });

            return validations;
        }
    }
}
