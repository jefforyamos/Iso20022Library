﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancellationReason39Choice.  ISO2002 ID# _l0B_2Qd4Ee2fOITqoTnSLQ.
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
    /// Choice of format for the cancellation processing status.
    /// </summary>
    [KnownType(typeof(CancellationReason39Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancellationReason39Choice.Reason))]
    [IsoId("_l0B_2Qd4Ee2fOITqoTnSLQ")]
    [DisplayName("Cancellation Reason 39 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancellationReason39Choice_
    #else
    public abstract partial class CancellationReason39Choice_
    #endif
    {
    }
}
