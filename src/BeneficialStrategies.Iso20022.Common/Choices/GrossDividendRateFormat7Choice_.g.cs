﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GrossDividendRateFormat7Choice.  ISO2002 ID# _nEgpwRFaEeKp2ZN13DI_pA.
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
    [KnownType(typeof(GrossDividendRateFormat7Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat7Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat7Choice.NotSpecifiedRate))]
    [IsoId("_nEgpwRFaEeKp2ZN13DI_pA")]
    [DisplayName("Gross Dividend Rate Format 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat7Choice_
    #else
    public abstract partial class GrossDividendRateFormat7Choice_
    #endif
    {
    }
}
