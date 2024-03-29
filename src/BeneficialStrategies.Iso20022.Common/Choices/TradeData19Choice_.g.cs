﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeData19Choice.  ISO2002 ID# _mijCQXg-Eeu3kecHd7QKUQ.
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
    /// Position/transaction reporting under EMIR regulation.
    /// </summary>
    [KnownType(typeof(TradeData19Choice.DataSetAction))]
    [KnownType(typeof(TradeData19Choice.Report))]
    [KnownType(typeof(TradeData19Choice.State))]
    [IsoId("_mijCQXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Trade Data 19 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeData19Choice_
    #else
    public abstract partial class TradeData19Choice_
    #endif
    {
    }
}
