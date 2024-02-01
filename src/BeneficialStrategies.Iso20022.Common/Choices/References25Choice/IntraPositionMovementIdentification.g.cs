﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IntraPositionMovementIdentification.  ISO2002 ID# _XGUCR_7uEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References25Choice;

/// <summary>
/// Unambiguous identification of the intra-position movement transaction as known by the account owner (or instructing party acting on its behalf).
/// </summary>
public partial record IntraPositionMovementIdentification : References25Choice_
{
    public required IsoMax35Text Value { get; init; }
}
