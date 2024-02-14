﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus69Choice.  ISO2002 ID# _1m2RQeF7EeWCAvUNsZ5u6g.
//

using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the processing status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus69Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus69Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus69Choice.Repair))]
    [KnownType(typeof(ProcessingStatus69Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus69Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus69Choice.Denied))]
    [KnownType(typeof(ProcessingStatus69Choice.Cancelled))]
    [IsoId("_1m2RQeF7EeWCAvUNsZ5u6g")]
    [DisplayName("Processing Status 69 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus69Choice_
    #else
    public abstract partial class ProcessingStatus69Choice_
    #endif
    {
    }
}
