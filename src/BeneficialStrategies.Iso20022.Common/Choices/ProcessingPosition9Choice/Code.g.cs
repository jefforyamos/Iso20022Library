﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _0_e442axEeWZev0W8F756g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ProcessingPosition9Choice;

/// <summary>
/// Processing position expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ProcessingPosition9Choice_
{
    public required ProcessingPosition5Code Value { get; init; }
}
