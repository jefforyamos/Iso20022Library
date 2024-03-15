﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat51Choice.  ISO2002 ID# _eN9Dj5SiEeeh5JjedkaA_g.
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
    /// Choice of format between a rate or a deemed rate type and rate or an amount or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat51Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat51Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat51Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat51Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat51Choice.RateTypeAndRate))]
    [IsoId("_eN9Dj5SiEeeh5JjedkaA_g")]
    [DisplayName("Rate And Amount Format 51 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat51Choice_
    #else
    public abstract partial class RateAndAmountFormat51Choice_
    #endif
    {
    }
}
