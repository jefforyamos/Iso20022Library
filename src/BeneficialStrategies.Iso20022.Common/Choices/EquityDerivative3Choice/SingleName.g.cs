﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SingleName.  ISO2002 ID# _hW-FPGlPEeaLAKoEUNsD9g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.EquityDerivative3Choice;

/// <summary>
/// Populated when sub asset class is either swaps or portfolio swaps and the underlying type is a single name.
/// </summary>
public partial record SingleName : EquityDerivative3Choice_
{
    public required UnderlyingEquityType5Code Value { get; init; }
}
