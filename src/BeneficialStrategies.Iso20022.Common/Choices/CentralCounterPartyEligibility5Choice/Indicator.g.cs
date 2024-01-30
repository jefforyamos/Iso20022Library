﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _5m6oNZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CentralCounterPartyEligibility5Choice;

/// <summary>
/// Specifies whether the settlement transaction is CCP (Central Counterparty) eligible.
/// </summary>
public partial record Indicator : ICentralCounterPartyEligibility5Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}
