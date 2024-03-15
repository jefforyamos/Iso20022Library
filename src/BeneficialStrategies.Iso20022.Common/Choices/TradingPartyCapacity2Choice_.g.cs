﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradingPartyCapacity2Choice.  ISO2002 ID# _AXehUdokEeC60axPepSq7g_-114557953.
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
    /// Choice of format for the trading capacity.
    /// </summary>
    [KnownType(typeof(TradingPartyCapacity2Choice.Code))]
    [KnownType(typeof(TradingPartyCapacity2Choice.Proprietary))]
    [IsoId("_AXehUdokEeC60axPepSq7g_-114557953")]
    [DisplayName("Trading Party Capacity 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradingPartyCapacity2Choice_
    #else
    public abstract partial class TradingPartyCapacity2Choice_
    #endif
    {
    }
}
