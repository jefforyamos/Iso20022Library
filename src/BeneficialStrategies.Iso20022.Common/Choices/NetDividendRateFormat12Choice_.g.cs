﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for NetDividendRateFormat12Choice.  ISO2002 ID# _3guyPxLnEeKJ5uSjVyVvug.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
    [KnownType(typeof(NetDividendRateFormat12Choice.Amount))]
    [KnownType(typeof(NetDividendRateFormat12Choice.RateTypeAndAmountAndRateStatus))]
    [IsoId("_3guyPxLnEeKJ5uSjVyVvug")]
    [DisplayName("Net Dividend Rate Format 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record NetDividendRateFormat12Choice_
    #else
    public abstract partial class NetDividendRateFormat12Choice_
    #endif
    {
    }
}
