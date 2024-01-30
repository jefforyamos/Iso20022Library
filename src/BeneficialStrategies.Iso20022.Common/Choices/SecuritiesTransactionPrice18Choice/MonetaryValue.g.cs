﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MonetaryValue.  ISO2002 ID# _m8q24MgpEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice18Choice;

/// <summary>
/// Indicates that price is expressed as a monetary value.
/// </summary>
public partial record MonetaryValue : ISecuritiesTransactionPrice18Choice
{
    #nullable enable
    /// <summary>
    /// Amount of money in the cash entry.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAnd20DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Indicates that the amount value is positive or negative.
    /// </summary>
    public IsoPlusOrMinusIndicator? Sign { get; init; } 
    #nullable disable
}
