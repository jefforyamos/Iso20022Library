﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxCreditRateFormat5Choice.  ISO2002 ID# _DeFVIOwPEd-sn-FiNtktcA.
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
    [KnownType(typeof(TaxCreditRateFormat5Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat5Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(TaxCreditRateFormat5Choice.NotSpecifiedRate))]
    [IsoId("_DeFVIOwPEd-sn-FiNtktcA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Credit Rate Format 5 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxCreditRateFormat5Choice_
    #else
    public abstract partial class TaxCreditRateFormat5Choice_
    #endif
    {
    }
}
