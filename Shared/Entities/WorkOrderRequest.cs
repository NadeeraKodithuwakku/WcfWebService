﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    [DataContract]
    public class WorkOrderRequest
    {
        [DataMember]
        public WorkOrderDetails WorkOrderDetails { get; set; }

        //to be added other tabs

    }
}
