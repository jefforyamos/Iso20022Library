﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeOriginator4Choice.  ISO2002 ID# _5mtMh5NLEeWGlc8L7oPDIg.
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
    /// Choice of format for the trading capacity of the party.
    /// </summary>
    [KnownType(typeof(TradeOriginator4Choice.Code))]
    [KnownType(typeof(TradeOriginator4Choice.Proprietary))]
    [IsoId("_5mtMh5NLEeWGlc8L7oPDIg")]
    [DisplayName("Trade Originator 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeOriginator4Choice_
    #else
    public abstract partial class TradeOriginator4Choice_
    #endif
    {
    }
}
