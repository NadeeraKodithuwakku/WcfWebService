using System.Collections.Generic;

namespace WorkOrderData
{
    public interface IDatabaseManager
    {
        void AddWorkDetails(WorkOrderDetails workOrderDetails);
        List<WorkOrderDetails> Read();
    }
}