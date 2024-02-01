﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FundSettlementParameters16.  ISO2002 ID# _rssUUZGVEem-9Y6mq5ZH3Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters applied to the settlement of a security.
/// </summary>
public partial record FundSettlementParameters16
{
    #nullable enable
    
    /// <summary>
    /// Condition under which the order/trade is to be/was executed. This may be required for settlement through T2S.
    /// </summary>
    public TradeTransactionCondition8Choice_[] TradeTransactionCondition { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Condition under which the order/trade is to be settled. This may be required for settlement through T2S.
    /// </summary>
    public SettlementTransactionCondition30Choice_[] SettlementTransactionCondition { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of a specific system or set of rules and/or processes to be applied at the settlement place.
    /// </summary>
    public IsoMax35Text? SecuritiesSettlementSystemIdentification { get; init; } 
    /// <summary>
    /// Chain of receiving settlement parties.
    /// </summary>
    public SettlementParties94? ReceivingSideDetails { get; init; } 
    
    #nullable disable
}
