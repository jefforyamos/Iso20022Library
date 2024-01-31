﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _bWl_jRLBEeqctpBfTmLJnw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradePositionReport7Choice;

/// <summary>
/// Indicates any other amendment to the terms or details of a previously reported position.
/// </summary>
public partial record Other : ITradePositionReport7Choice
{
    #nullable enable
    /// <summary>
    /// Counterparty data details.
    /// </summary>
    public IReadOnlyCollection<CounterpartySpecificData22> CounterpartySpecificData { get; init; } = [];
    /// <summary>
    /// Data specifically related to transaction.
    /// </summary>
    public required CommonTradeDataReport37 CommonTradeData { get; init; } 
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
