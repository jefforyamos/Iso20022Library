﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cjsao5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IntermediateSecuritiesDistributionTypeFormat17Choice;

/// <summary>
/// Standard code to specify the type of intermediate security distribution.
/// </summary>
public partial record Code : IIntermediateSecuritiesDistributionTypeFormat17Choice
{
    public required IntermediateSecurityDistributionType4Code Value { get; init; }
}
