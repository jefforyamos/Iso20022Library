﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GrossDividendRateFormat22Choice.  ISO2002 ID# _ChudIWXGEeWht50_j0HXAQ.
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
    /// Choice of format to express a gross dividend.
    /// </summary>
    [KnownType(typeof(GrossDividendRateFormat22Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat22Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat22Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_ChudIWXGEeWht50_j0HXAQ")]
    [DisplayName("Gross Dividend Rate Format 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat22Choice_
    #else
    public abstract partial class GrossDividendRateFormat22Choice_
    #endif
    {
    }
}
