﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SuspendedStatusReason4Choice.  ISO2002 ID# _Z5vRgUHlEea8I67lh6qdSQ.
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
    /// Reason for a suspended status.
    /// </summary>
    [KnownType(typeof(SuspendedStatusReason4Choice.NoSpecifiedReason))]
    [KnownType(typeof(SuspendedStatusReason4Choice.ReasonDetails))]
    [IsoId("_Z5vRgUHlEea8I67lh6qdSQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Suspended Status Reason 4 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SuspendedStatusReason4Choice_
    #else
    public abstract partial class SuspendedStatusReason4Choice_
    #endif
    {
    }
}
