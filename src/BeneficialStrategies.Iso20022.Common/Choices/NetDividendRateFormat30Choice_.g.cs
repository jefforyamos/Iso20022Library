﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NetDividendRateFormat30Choice.  ISO2002 ID# _AUTxtZb8Eee8S7xwGG7Veg.
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
    [KnownType(typeof(NetDividendRateFormat30Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat30Choice.AmountAndRateStatus))]
    [KnownType(typeof(NetDividendRateFormat30Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_AUTxtZb8Eee8S7xwGG7Veg")]
    [DisplayName("Net Dividend Rate Format 30 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat30Choice_
    #else
    public abstract partial class NetDividendRateFormat30Choice_
    #endif
    {
    }
}
