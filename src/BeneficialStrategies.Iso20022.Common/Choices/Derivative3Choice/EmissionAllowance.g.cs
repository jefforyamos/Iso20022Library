﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EmissionAllowance.  ISO2002 ID# _xH-zbSe0Eei12pGEsJIAeQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Derivative3Choice;

/// <summary>
/// Details specific for emission allowance derivatives
/// </summary>
public partial record EmissionAllowance : Derivative3Choice_
{
    public required EmissionAllowanceProductType1Code Value { get; init; }
}
