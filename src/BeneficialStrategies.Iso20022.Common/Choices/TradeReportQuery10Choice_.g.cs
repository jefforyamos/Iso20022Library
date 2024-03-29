﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for TradeReportQuery10Choice.  ISO2002 ID# _eqwjId1dEeqxpKDfBZC1vg.
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
    /// Defines the type of the query, a recurrent or an ad-hoc query.
    /// </summary>
    [KnownType(typeof(TradeReportQuery10Choice.AdHocQuery))]
    [KnownType(typeof(TradeReportQuery10Choice.RecurrentQuery))]
    [IsoId("_eqwjId1dEeqxpKDfBZC1vg")]
    [DisplayName("Trade Report Query 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradeReportQuery10Choice_
    #else
    public abstract partial class TradeReportQuery10Choice_
    #endif
    {
    }
}
