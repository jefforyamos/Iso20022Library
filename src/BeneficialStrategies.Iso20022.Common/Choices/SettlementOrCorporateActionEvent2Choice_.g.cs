﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementOrCorporateActionEvent2Choice.  ISO2002 ID# _QtevFNp-Ed-ak6NoX_4Aeg_-286184680.
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
    [KnownType(typeof(SettlementOrCorporateActionEvent2Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent2Choice.CorporateActionEventType))]
    [IsoId("_QtevFNp-Ed-ak6NoX_4Aeg_-286184680")]
    [DisplayName("Settlement Or Corporate Action Event 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent2Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent2Choice_
    #endif
    {
    }
}
