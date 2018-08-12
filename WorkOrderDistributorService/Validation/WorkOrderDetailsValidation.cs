using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkOrderDistributorService.Validation
{
    public class WorkOrderDetailsValidation
    {
        public static bool IsValidDistibutorNumber(string distibutorNumber)
        {
            if (string.IsNullOrEmpty(distibutorNumber))
            {
                return false;
            }
            return true;
        }

        public static bool IsValidWorkOrderNumber(string modelNumber)
        {
            if (string.IsNullOrEmpty(modelNumber))
            {
                return false;
            }
            return true;
        }
    }
}