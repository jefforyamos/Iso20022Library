﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InterestRateUsedForPaymentFormat5Choice.  ISO2002 ID# _iS_3geEREd-1Ktb5rVaajw.
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
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat5Choice.NotSpecifiedRate))]
    [IsoId("_iS_3geEREd-1Ktb5rVaajw")]
    [DisplayName("Interest Rate Used For Payment Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRateUsedForPaymentFormat5Choice_
    #else
    public abstract partial class InterestRateUsedForPaymentFormat5Choice_
    #endif
    {
    }
}
