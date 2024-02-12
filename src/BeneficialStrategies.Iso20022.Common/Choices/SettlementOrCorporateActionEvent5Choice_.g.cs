﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by AbstractChoiceGenerator for SettlementOrCorporateActionEvent5Choice.  ISO2002 ID# _PlRa6fvmEeCBQp5TnX1XKQ.
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
    [KnownType(typeof(SettlementOrCorporateActionEvent5Choice.SecuritiesTransactionType))]
    [KnownType(typeof(SettlementOrCorporateActionEvent5Choice.CorporateActionEventType))]
    [IsoId("_PlRa6fvmEeCBQp5TnX1XKQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Settlement Or Corporate Action Event 5 Choice")]
    #endif
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementOrCorporateActionEvent5Choice_
    #else
    public abstract partial class SettlementOrCorporateActionEvent5Choice_
    #endif
    {
    }
}
