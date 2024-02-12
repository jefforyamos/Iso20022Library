﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InRepairStatusReason4Choice.  ISO2002 ID# _BRBdEUHqEea8I67lh6qdSQ.
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
    /// Choice of formats for the reason for an in repair status.
    /// </summary>
    [KnownType(typeof(InRepairStatusReason4Choice.NoSpecifiedReason))]
    [KnownType(typeof(InRepairStatusReason4Choice.ReasonDetails))]
    [IsoId("_BRBdEUHqEea8I67lh6qdSQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("In Repair Status Reason 4 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InRepairStatusReason4Choice_
    #else
    public abstract partial class InRepairStatusReason4Choice_
    #endif
    {
    }
}
