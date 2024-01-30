﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraBalanceMovementIdentification.  ISO2002 ID# _5Pat75NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References50Choice;

/// <summary>
/// Unambiguous identification of the intra balance movement transaction as known by the account owner.
/// </summary>
public partial record IntraBalanceMovementIdentification : IReferences50Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
