﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancelledStatus3Choice.  ISO2002 ID# _V4EH7eJxEd-Q6MzBzY5WkA.
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
    /// Choice between a reason or no reason for the corporate action instruction or instruction cancellation cancelled/cancellation completed status.
    /// </summary>
    [KnownType(typeof(CancelledStatus3Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus3Choice.Reason))]
    [IsoId("_V4EH7eJxEd-Q6MzBzY5WkA")]
    [DisplayName("Cancelled Status 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledStatus3Choice_
    #else
    public abstract partial class CancelledStatus3Choice_
    #endif
    {
    }
}
