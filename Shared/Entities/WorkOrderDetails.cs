using System;
using System.Runtime.Serialization;

[DataContract]
public class WorkOrderDetails
{
    [DataMember]
    public int UnitId { get; set; }

    [DataMember]
    public string DistributorNumber { get; set; }

    [DataMember]
    public string WorkOrderNumber { get; set; }

}
