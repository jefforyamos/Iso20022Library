﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for RateAndAmountFormat50Choice.  ISO2002 ID# _c5SQhZKQEeWHWpTQn1FFVg.
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
    /// Choice of format between a rate, an amount, index points or a unspecified rate.
    /// </summary>
    [KnownType(typeof(RateAndAmountFormat50Choice.Rate))]
    [KnownType(typeof(RateAndAmountFormat50Choice.NotSpecifiedRate))]
    [KnownType(typeof(RateAndAmountFormat50Choice.Amount))]
    [KnownType(typeof(RateAndAmountFormat50Choice.IndexPoints))]
    [IsoId("_c5SQhZKQEeWHWpTQn1FFVg")]
    [DisplayName("Rate And Amount Format 50 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateAndAmountFormat50Choice_
    #else
    public abstract partial class RateAndAmountFormat50Choice_
    #endif
    {
    }
}
