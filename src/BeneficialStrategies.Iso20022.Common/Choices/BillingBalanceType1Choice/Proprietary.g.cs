﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _6Q_lhpqlEeGSON8vddiWzQ_1258331398.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BillingBalanceType1Choice;

/// <summary>
/// Defines the type of billing balance, in a proprietary format.
/// </summary>
public partial record Proprietary : IBillingBalanceType1Choice
{
    public required IsoMax35Text Value { get; init; }
}
