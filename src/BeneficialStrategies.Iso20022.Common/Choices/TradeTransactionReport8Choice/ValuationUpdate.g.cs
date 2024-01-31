﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ValuationUpdate.  ISO2002 ID# _bRuGmxLBEeqctpBfTmLJnw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeTransactionReport8Choice;

/// <summary>
/// Indicates an update of a contract valuation or collateral.
/// </summary>
public partial record ValuationUpdate : ITradeTransactionReport8Choice
{
    #nullable enable
    /// <summary>
    /// Trade transaction data details.
    /// </summary>
    public IReadOnlyCollection<CounterpartySpecificData23> CounterpartySpecificData { get; init; } = [];
    /// <summary>
    /// Trade transaction data details.
    /// </summary>
    public CommonTradeDataReport36? CommonTradeData { get; init; } 
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    public TechnicalAttributes1? TechnicalAttributes { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}
