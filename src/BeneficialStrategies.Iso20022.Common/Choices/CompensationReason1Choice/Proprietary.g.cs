﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _d3NU0IjYEeeDW7_wB-eK_g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CompensationReason1Choice;

/// <summary>
/// Reason for the payment compensation, in a proprietary form.
/// </summary>
public partial record Proprietary : ICompensationReason1Choice
{
    public required IsoMax35Text Value { get; init; }
}
