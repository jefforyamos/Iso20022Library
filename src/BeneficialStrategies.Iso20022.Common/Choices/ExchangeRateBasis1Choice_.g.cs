﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ExchangeRateBasis1Choice.  ISO2002 ID# _n2_eYLppEea_jI1vMH_RbA.
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
    /// Provides information about the exchange rate basis for a foreign exchange transaction.
    /// </summary>
    [KnownType(typeof(ExchangeRateBasis1Choice.CurrencyPair))]
    [KnownType(typeof(ExchangeRateBasis1Choice.Proprietary))]
    [IsoId("_n2_eYLppEea_jI1vMH_RbA")]
    [DisplayName("Exchange Rate Basis 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExchangeRateBasis1Choice_
    #else
    public abstract partial class ExchangeRateBasis1Choice_
    #endif
    {
    }
}
