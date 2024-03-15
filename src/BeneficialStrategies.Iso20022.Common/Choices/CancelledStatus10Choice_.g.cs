﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for CancelledStatus10Choice.  ISO2002 ID# _1k2bQTt5EeW638lNyHKv7A.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(CancelledStatus10Choice.NoSpecifiedReason))]
    [KnownType(typeof(CancelledStatus10Choice.Reason))]
    [IsoId("_1k2bQTt5EeW638lNyHKv7A")]
    [DisplayName("Cancelled Status 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CancelledStatus10Choice_
    #else
    public abstract partial class CancelledStatus10Choice_
    #endif
    {
    }
}
