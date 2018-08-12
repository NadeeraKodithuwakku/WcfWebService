using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Entities
{
    [DataContract]
    public class ValidationError
    {
        [DataMember]
        public string Field { get; set; }

        [DataMember]
        public string ValidationMessage { get; set; }

        [DataMember]
        public ValidationType ValidationType { get; set; }


    }
}
