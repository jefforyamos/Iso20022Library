﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementStatus7Choice.  ISO2002 ID# _Bsv4If40EeClUvPNHKL9Zw.
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
    /// Choice of format for the settlement status.
    /// </summary>
    [KnownType(typeof(SettlementStatus7Choice.Pending))]
    [KnownType(typeof(SettlementStatus7Choice.Failing))]
    [KnownType(typeof(SettlementStatus7Choice.Proprietary))]
    [IsoId("_Bsv4If40EeClUvPNHKL9Zw")]
    [DisplayName("Settlement Status 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementStatus7Choice_
    #else
    public abstract partial class SettlementStatus7Choice_
    #endif
    {
    }
}
