﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Direction.  ISO2002 ID# _HmpucC0YEe2ZUuvBHegNNg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Direction4Choice;

/// <summary>
/// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker).
/// Usage:
/// DirectionOfTheFirstLeg should be used for most swaps and swap-like contracts including interest rate swaps, credit total return swaps, and equity swaps (except for credit default swaps, variance, volatility, and correlation swaps) as well as for the foreign exchange swaps, forwards and non-deliverable forwards.
/// </summary>
public partial record Direction : IDirection4Choice
{
    #nullable enable
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the first leg as determined at the time of transaction.
    /// </summary>
    public required OptionParty3Code DirectionOfTheFirstLeg { get; init; } 
    /// <summary>
    /// Identifies whether the reporting counterparty is the payer (Taker) or the receiver (Maker) of the second leg as determined at the time of transaction.
    /// </summary>
    public OptionParty3Code? DirectionOfTheSecondLeg { get; init; } 
    #nullable disable
}
