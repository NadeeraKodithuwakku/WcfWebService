using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    [DataContract]
    public class WorkOrderResponse
    {

        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public List<ValidationError> ValidationErrors { get; set; }

    }
}
