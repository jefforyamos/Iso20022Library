﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for PendingReason59Choice.  ISO2002 ID# _glk6gxHpEeuE0Pnt-OcNOA.
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
    /// Choice between a standard code and a proprietary code to specify the reason why the instruction/event has a pending status.
    /// </summary>
    [KnownType(typeof(PendingReason59Choice.Code))]
    [KnownType(typeof(PendingReason59Choice.Proprietary))]
    [IsoId("_glk6gxHpEeuE0Pnt-OcNOA")]
    [DisplayName("Pending Reason 59 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PendingReason59Choice_
    #else
    public abstract partial class PendingReason59Choice_
    #endif
    {
    }
}
