﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ssJ7k2W6EeSHcOWXSsMhqw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CommissionType5Choice;

/// <summary>
/// Commission type expressed as a code.
/// </summary>
public partial record Code : ICommissionType5Choice
{
    public required CommissionType6Code Value { get; init; }
}
