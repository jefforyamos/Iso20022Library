﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _6Q_lg5qlEeGSON8vddiWzQ_1364627181.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BillingCompensationType1Choice;

/// <summary>
/// Defines the type of billing compensation, as defined in a proprietary format.
/// </summary>
public partial record Proprietary : BillingCompensationType1Choice_
{
    public required IsoMax35Text Value { get; init; }
}
