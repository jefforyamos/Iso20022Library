﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _74nut6MgEeCJ6YNENx4h-w_1305183982.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType8Choice;

/// <summary>
/// Specifies the nature of a balance, in a proprietary form.
/// </summary>
public partial record Proprietary : IBalanceType8Choice
{
    public required IsoMax35Text Value { get; init; }
}
