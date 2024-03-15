﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GrossDividendRateFormat42Choice.  ISO2002 ID# _bZ_lFwVTEeqjd8n6wD9JVw.
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
    [KnownType(typeof(GrossDividendRateFormat42Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat42Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat42Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat42Choice.NotSpecifiedRate))]
    [IsoId("_bZ_lFwVTEeqjd8n6wD9JVw")]
    [DisplayName("Gross Dividend Rate Format 42 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat42Choice_
    #else
    public abstract partial class GrossDividendRateFormat42Choice_
    #endif
    {
    }
}
