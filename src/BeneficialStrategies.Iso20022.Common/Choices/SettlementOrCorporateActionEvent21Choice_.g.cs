﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementOrCorporateActionEvent21Choice.  ISO2002 ID# _zmv3zZwxEeazcsnODTksnQ.
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
    /// Choice of transaction type, corporate action event or settlement transaction.
    /// </summary>
    [KnownType(typeof(SettlementOrCorporateActionEvent21Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent21Choice.CorporateActionEventType))]
    [IsoId("_zmv3zZwxEeazcsnODTksnQ")]
    [DisplayName("Settlement Or Corporate Action Event 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent21Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent21Choice_
    #endif
    {
    }
}
