﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cta-FZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntermediateSecuritiesDistributionTypeFormat18Choice;

/// <summary>
/// Standard code to specify the type of intermediate security distribution.
/// </summary>
public partial record Code : IntermediateSecuritiesDistributionTypeFormat18Choice_
{
    public required IntermediateSecurityDistributionType5Code Value { get; init; }
}
