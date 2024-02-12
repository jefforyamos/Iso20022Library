﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TaxCreditRateFormat2Choice.  ISO2002 ID# _UMtPDtp-Ed-ak6NoX_4Aeg_-1830345508.
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
    [KnownType(typeof(TaxCreditRateFormat2Choice.Rate))]
    [KnownType(typeof(TaxCreditRateFormat2Choice.Amount))]
    [KnownType(typeof(TaxCreditRateFormat2Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_UMtPDtp-Ed-ak6NoX_4Aeg_-1830345508")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Tax Credit Rate Format 2 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TaxCreditRateFormat2Choice_
    #else
    public abstract partial class TaxCreditRateFormat2Choice_
    #endif
    {
    }
}
