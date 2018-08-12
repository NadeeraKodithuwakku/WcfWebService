using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributorService.Core
{
    public interface IWorkOrderManager
    {
        List<ValidationError> ValidateWorkOrder(WorkOrderRequest request);
    }
}
