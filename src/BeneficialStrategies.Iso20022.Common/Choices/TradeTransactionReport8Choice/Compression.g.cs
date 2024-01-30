﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Compression.  ISO2002 ID# _bRuGnRLBEeqctpBfTmLJnw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeTransactionReport8Choice;

/// <summary>
/// Indicates a compression of the reported contract.
/// </summary>
public partial record Compression : ITradeTransactionReport8Choice
{
    #nullable enable
    /// <summary>
    /// Counterparty data details.
    /// </summary>
    // public IReadOnlyCollection<CounterpartySpecificData22> CounterpartySpecificData { get; init; }
    /// <summary>
    /// Contract and transaction trade data details.
    /// </summary>
    public required CommonTradeDataReport34 CommonTradeData { get; init; } 
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
