﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _KGJT00EGEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntermediateSecuritiesDistributionTypeFormat15Choice;

/// <summary>
/// Standard code to specify the type of intermediate security distribution.
/// </summary>
public partial record Code : IIntermediateSecuritiesDistributionTypeFormat15Choice
{
    public required IntermediateSecurityDistributionType5Code Value { get; init; }
}
