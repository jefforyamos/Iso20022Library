﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SystematicInternaliser.  ISO2002 ID# _TCpPotp-Ed-ak6NoX_4Aeg_-1823256758.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OffMarket1Choice;

/// <summary>
/// Provides the BIC code of the systematic internaliser.
/// </summary>
public partial record SystematicInternaliser : IOffMarket1Choice
{
    public required IsoAnyBICIdentifier Value { get; init; }
}
