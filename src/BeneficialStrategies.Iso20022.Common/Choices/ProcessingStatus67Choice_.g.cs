﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ProcessingStatus67Choice.  ISO2002 ID# _W7Icl-FUEeWIA4E9cYSxxQ.
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
    [KnownType(typeof(ProcessingStatus67Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus67Choice.Repair))]
    [KnownType(typeof(ProcessingStatus67Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus67Choice.AcknowledgedAccepted))]
    [KnownType(typeof(ProcessingStatus67Choice.Proprietary))]
    [IsoId("_W7Icl-FUEeWIA4E9cYSxxQ")]
    [DisplayName("Processing Status 67 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProcessingStatus67Choice_
    #else
    public abstract partial class ProcessingStatus67Choice_
    #endif
    {
    }
}
