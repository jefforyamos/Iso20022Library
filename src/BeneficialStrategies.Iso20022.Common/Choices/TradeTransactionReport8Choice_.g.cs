﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeTransactionReport8Choice.  ISO2002 ID# _bQpIhRLBEeqctpBfTmLJnw.
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
    /// Provides details on the reported trade transactions.
    /// </summary>
    [KnownType(typeof(TradeTransactionReport8Choice.New))]
    [KnownType(typeof(TradeTransactionReport8Choice.Modification))]
    [KnownType(typeof(TradeTransactionReport8Choice.Correction))]
    [KnownType(typeof(TradeTransactionReport8Choice.EarlyTermination))]
    [KnownType(typeof(TradeTransactionReport8Choice.PositionComponent))]
    [KnownType(typeof(TradeTransactionReport8Choice.ValuationUpdate))]
    [KnownType(typeof(TradeTransactionReport8Choice.Compression))]
    [KnownType(typeof(TradeTransactionReport8Choice.Error))]
    [KnownType(typeof(TradeTransactionReport8Choice.Other))]
    [IsoId("_bQpIhRLBEeqctpBfTmLJnw")]
    [DisplayName("Trade Transaction Report 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeTransactionReport8Choice_
    #else
    public abstract partial class TradeTransactionReport8Choice_
    #endif
    {
    }
}
