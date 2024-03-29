﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NetDividendRateFormat33Choice.  ISO2002 ID# _skrJq83wEee5nJBZsW8MFQ.
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
    /// Choice between an amount or an unspecified rate.
    /// </summary>
    [KnownType(typeof(NetDividendRateFormat33Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat33Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat33Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_skrJq83wEee5nJBZsW8MFQ")]
    [DisplayName("Net Dividend Rate Format 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat33Choice_
    #else
    public abstract partial class NetDividendRateFormat33Choice_
    #endif
    {
    }
}
