﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus96Choice.  ISO2002 ID# _gBzJZzi8Eeydid5dcNPKvg.
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
    [KnownType(typeof(ProcessingStatus96Choice.PendingCancellation))]
    [KnownType(typeof(ProcessingStatus96Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus96Choice.Repair))]
    [KnownType(typeof(ProcessingStatus96Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus96Choice.Proprietary))]
    [KnownType(typeof(ProcessingStatus96Choice.Denied))]
    [KnownType(typeof(ProcessingStatus96Choice.Cancelled))]
    [IsoId("_gBzJZzi8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status 96 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus96Choice_
    #else
    public abstract partial class ProcessingStatus96Choice_
    #endif
    {
    }
}
