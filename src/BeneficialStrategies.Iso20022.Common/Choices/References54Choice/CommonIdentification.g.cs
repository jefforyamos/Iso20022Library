﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CommonIdentification.  ISO2002 ID# _6GW9DZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References54Choice;

/// <summary>
/// Unique reference agreed upon by the two trade counterparties to identify the trade.
/// </summary>
public partial record CommonIdentification : IReferences54Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
