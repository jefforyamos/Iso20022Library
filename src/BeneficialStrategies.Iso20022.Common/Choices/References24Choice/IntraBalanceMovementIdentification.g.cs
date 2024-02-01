﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraBalanceMovementIdentification.  ISO2002 ID# _H-crRf7uEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References24Choice;

/// <summary>
/// Unambiguous identification of the intra balance movement transaction as known by the account owner.
/// </summary>
public partial record IntraBalanceMovementIdentification : References24Choice_
{
    public required IsoMax35Text Value { get; init; }
}
