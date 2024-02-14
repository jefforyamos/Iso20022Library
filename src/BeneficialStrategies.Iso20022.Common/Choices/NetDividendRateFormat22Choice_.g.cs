﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NetDividendRateFormat22Choice.  ISO2002 ID# _Osj8UWOXEeWYYI9c62RCjw.
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
    [KnownType(typeof(NetDividendRateFormat22Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat22Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat22Choice.RateTypeAndAmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat22Choice.NotSpecifiedRate))]
    [IsoId("_Osj8UWOXEeWYYI9c62RCjw")]
    [DisplayName("Net Dividend Rate Format 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat22Choice_
    #else
    public abstract partial class NetDividendRateFormat22Choice_
    #endif
    {
    }
}
