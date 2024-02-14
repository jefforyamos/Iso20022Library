﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ExchangeRateReportOrError1Choice.  ISO2002 ID# _77JeQ6MgEeCJ6YNENx4h-w_1304764556.
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
    /// It is used to provide information on static data maintained by the transaction administrator and related to currency exchange details as maintained for system operations by the transaction administrator.
    /// </summary>
    [KnownType(typeof(ExchangeRateReportOrError1Choice.CurrencyExchangeReport))]
    [KnownType(typeof(ExchangeRateReportOrError1Choice.OperationalError))]
    [IsoId("_77JeQ6MgEeCJ6YNENx4h-w_1304764556")]
    [DisplayName("Exchange Rate Report Or Error 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExchangeRateReportOrError1Choice_
    #else
    public abstract partial class ExchangeRateReportOrError1Choice_
    #endif
    {
    }
}
