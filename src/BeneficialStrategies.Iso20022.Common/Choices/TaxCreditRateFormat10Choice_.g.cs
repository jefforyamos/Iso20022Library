﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxCreditRateFormat10Choice.  ISO2002 ID# _ctjhL5KQEeWHWpTQn1FFVg.
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
    [KnownType(typeof(TaxCreditRateFormat10Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat10Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat10Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(TaxCreditRateFormat10Choice.NotSpecifiedRate))]
    [IsoId("_ctjhL5KQEeWHWpTQn1FFVg")]
    [DisplayName("Tax Credit Rate Format 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxCreditRateFormat10Choice_
    #else
    public abstract partial class TaxCreditRateFormat10Choice_
    #endif
    {
    }
}
