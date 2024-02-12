﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for GrossDividendRateFormat31Choice.  ISO2002 ID# _skrJQ83wEee5nJBZsW8MFQ.
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
    [KnownType(typeof(GrossDividendRateFormat31Choice.Amount))]
    [KnownType(typeof(GrossDividendRateFormat31Choice.AmountAndRateStatus))]
    [KnownType(typeof(GrossDividendRateFormat31Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_skrJQ83wEee5nJBZsW8MFQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Gross Dividend Rate Format 31 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GrossDividendRateFormat31Choice_
    #else
    public abstract partial class GrossDividendRateFormat31Choice_
    #endif
    {
    }
}
