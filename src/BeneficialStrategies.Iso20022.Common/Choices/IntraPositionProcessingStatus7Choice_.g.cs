﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for IntraPositionProcessingStatus7Choice.  ISO2002 ID# _4EhzQewLEeiazoAmcoGsBQ.
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
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Rejected))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Repair))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Cancelled))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.AcknowledgedAccepted))]
    [KnownType(typeof(IntraPositionProcessingStatus7Choice.Proprietary))]
    [IsoId("_4EhzQewLEeiazoAmcoGsBQ")]
    [DisplayName("Intra Position Processing Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntraPositionProcessingStatus7Choice_
    #else
    public abstract partial class IntraPositionProcessingStatus7Choice_
    #endif
    {
    }
}
