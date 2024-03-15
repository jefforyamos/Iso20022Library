﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat52Choice.  ISO2002 ID# _fFh9EJSoEeeh5JjedkaA_g.
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
    [KnownType(typeof(RateAndAmountFormat52Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat52Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat52Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(RateAndAmountFormat52Choice.RateTypeAndRate))]
    [IsoId("_fFh9EJSoEeeh5JjedkaA_g")]
    [DisplayName("Rate And Amount Format 52 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat52Choice_
    #else
    public abstract partial class RateAndAmountFormat52Choice_
    #endif
    {
    }
}
