﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InterestRateUsedForPaymentFormat10Choice.  ISO2002 ID# _cteBw5KQEeWHWpTQn1FFVg.
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
    /// Choice between an amount or a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat10Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat10Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat10Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat10Choice.NotSpecifiedRate))]
    [IsoId("_cteBw5KQEeWHWpTQn1FFVg")]
    [DisplayName("Interest Rate Used For Payment Format 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRateUsedForPaymentFormat10Choice_
    #else
    public abstract partial class InterestRateUsedForPaymentFormat10Choice_
    #endif
    {
    }
}
