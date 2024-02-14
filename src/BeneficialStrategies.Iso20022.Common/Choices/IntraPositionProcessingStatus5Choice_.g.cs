﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IntraPositionProcessingStatus5Choice.  ISO2002 ID# _DwdiUTnuEeWfSKvvZlhRKg.
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
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus5Choice.Proprietary))]
    [IsoId("_DwdiUTnuEeWfSKvvZlhRKg")]
    [DisplayName("Intra Position Processing Status 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraPositionProcessingStatus5Choice_
    #else
    public abstract partial class IntraPositionProcessingStatus5Choice_
    #endif
    {
    }
}
