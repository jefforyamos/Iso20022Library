﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cz6_MBuBEeOqSdXzJ0oydA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CommissionType3Choice;

/// <summary>
/// Type of commission expressed as a code.
/// </summary>
public partial record Code : ICommissionType3Choice
{
    public required CommissionType7Code Value { get; init; }
}
