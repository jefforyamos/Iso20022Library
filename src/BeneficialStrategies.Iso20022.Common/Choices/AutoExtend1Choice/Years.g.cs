﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Years.  ISO2002 ID# _95fqcnltEeG7BsjMvd1mEw_960984968.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AutoExtend1Choice;

/// <summary>
/// Number of years.
/// </summary>
public partial record Years : IAutoExtend1Choice
{
    public required IsoNumber Value { get; init; }
}
