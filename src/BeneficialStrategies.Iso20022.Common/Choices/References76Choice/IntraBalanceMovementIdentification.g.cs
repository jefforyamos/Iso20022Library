﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraBalanceMovementIdentification.  ISO2002 ID# _diXSuTi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References76Choice;

/// <summary>
/// Unambiguous identification of the intra balance movement transaction as known by the account owner.
/// </summary>
public partial record IntraBalanceMovementIdentification : References76Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
