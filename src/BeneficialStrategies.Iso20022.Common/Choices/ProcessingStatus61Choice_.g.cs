﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus61Choice.  ISO2002 ID# _6QDryZNLEeWGlc8L7oPDIg.
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
    [KnownType(typeof(ProcessingStatus61Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus61Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus61Choice.Repair))]
    [KnownType(typeof(ProcessingStatus61Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus61Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus61Choice.Denied))]
    [KnownType(typeof(ProcessingStatus61Choice.Cancelled))]
    [IsoId("_6QDryZNLEeWGlc8L7oPDIg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Processing Status 61 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus61Choice_
    #else
    public abstract partial class ProcessingStatus61Choice_
    #endif
    {
    }
}
