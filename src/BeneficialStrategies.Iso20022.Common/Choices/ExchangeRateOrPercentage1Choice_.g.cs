﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for ExchangeRateOrPercentage1Choice.  ISO2002 ID# _lW_QMNfvEeqoweZZxm4TPQ.
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
    /// Specifies a choice between an absolute rate and a percentage rate. 
    /// </summary>
    [KnownType(typeof(ExchangeRateOrPercentage1Choice.Rate))]
    [KnownType(typeof(ExchangeRateOrPercentage1Choice.Percentage))]
    [IsoId("_lW_QMNfvEeqoweZZxm4TPQ")]
    [DisplayName("Exchange Rate Or Percentage 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ExchangeRateOrPercentage1Choice_
    #else
    public abstract partial class ExchangeRateOrPercentage1Choice_
    #endif
    {
    }
}
