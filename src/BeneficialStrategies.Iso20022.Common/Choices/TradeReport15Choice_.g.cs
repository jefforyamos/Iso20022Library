﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeReport15Choice.  ISO2002 ID# _oKFn1Xg-Eeu3kecHd7QKUQ.
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
    /// Position/transaction reporting under the local regulation.
    /// </summary>
    [KnownType(typeof(TradeReport15Choice.New))]
    [KnownType(typeof(TradeReport15Choice.Modification))]
    [KnownType(typeof(TradeReport15Choice.Correction))]
    [KnownType(typeof(TradeReport15Choice.Termination))]
    [KnownType(typeof(TradeReport15Choice.PositionComponent))]
    [KnownType(typeof(TradeReport15Choice.ValuationUpdate))]
    [KnownType(typeof(TradeReport15Choice.Compression))]
    [KnownType(typeof(TradeReport15Choice.Error))]
    [KnownType(typeof(TradeReport15Choice.Other))]
    [IsoId("_oKFn1Xg-Eeu3kecHd7QKUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Report 15 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeReport15Choice_
    #else
    public abstract partial class TradeReport15Choice_
    #endif
    {
    }
}
