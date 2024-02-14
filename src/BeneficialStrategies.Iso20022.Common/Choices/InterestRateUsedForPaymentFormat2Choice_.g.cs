﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for InterestRateUsedForPaymentFormat2Choice.  ISO2002 ID# _UM2Y_Np-Ed-ak6NoX_4Aeg_-807410440.
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
    /// Choice between an amount or a rate.
    /// </summary>
    [KnownType(typeof(InterestRateUsedForPaymentFormat2Choice.Rate))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat2Choice.Amount))]
    [KnownType(typeof(InterestRateUsedForPaymentFormat2Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_UM2Y_Np-Ed-ak6NoX_4Aeg_-807410440")]
    [DisplayName("Interest Rate Used For Payment Format 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InterestRateUsedForPaymentFormat2Choice_
    #else
    public abstract partial class InterestRateUsedForPaymentFormat2Choice_
    #endif
    {
    }
}
