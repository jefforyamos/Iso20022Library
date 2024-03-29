﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ExchangeRateReportOrError4Choice.  ISO2002 ID# _MobXpdfiEeqoweZZxm4TPQ.
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
    /// Reports either on currency exchange information or on a business error.
    /// </summary>
    [KnownType(typeof(ExchangeRateReportOrError4Choice.BusinessError))]
    [KnownType(typeof(ExchangeRateReportOrError4Choice.CurrencyExchange))]
    [IsoId("_MobXpdfiEeqoweZZxm4TPQ")]
    [DisplayName("Exchange Rate Report Or Error 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExchangeRateReportOrError4Choice_
    #else
    public abstract partial class ExchangeRateReportOrError4Choice_
    #endif
    {
    }
}
