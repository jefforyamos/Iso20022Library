﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus71Choice.  ISO2002 ID# _mZpJceGKEeWCAvUNsZ5u6g.
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
    [KnownType(typeof(ProcessingStatus71Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus71Choice.Pending))]
    [KnownType(typeof(ProcessingStatus71Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus71Choice.Repair))]
    [KnownType(typeof(ProcessingStatus71Choice.Denied))]
    [KnownType(typeof(ProcessingStatus71Choice.Completed))]
    [KnownType(typeof(ProcessingStatus71Choice.Proprietary))]
    [IsoId("_mZpJceGKEeWCAvUNsZ5u6g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Status 71 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus71Choice_
    #else
    public abstract partial class ProcessingStatus71Choice_
    #endif
    {
    }
}
