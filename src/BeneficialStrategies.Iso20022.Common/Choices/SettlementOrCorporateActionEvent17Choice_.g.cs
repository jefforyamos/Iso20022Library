﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementOrCorporateActionEvent17Choice.  ISO2002 ID# _fI9pUYyjEea-QrbCUXny2w.
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
    [KnownType(typeof(SettlementOrCorporateActionEvent17Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent17Choice.CorporateActionEventType))]
    [IsoId("_fI9pUYyjEea-QrbCUXny2w")]
    [DisplayName("Settlement Or Corporate Action Event 17 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent17Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent17Choice_
    #endif
    {
    }
}
