﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat20Choice.  ISO2002 ID# _S4q7DyeKEeOXAt_43VmZGw.
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
    /// Choice of format between a rate or a rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat20Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat20Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat20Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat20Choice.RateTypeAndRate))]
    [IsoId("_S4q7DyeKEeOXAt_43VmZGw")]
    [DisplayName("Rate And Amount Format 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat20Choice_
    #else
    public abstract partial class RateAndAmountFormat20Choice_
    #endif
    {
    }
}
