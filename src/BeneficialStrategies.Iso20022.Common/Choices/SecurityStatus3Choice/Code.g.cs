﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _GHDbQeLcEeWFtOV72FbX9w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityStatus3Choice;

/// <summary>
/// Security status expressed as an ISO 20022 code.
/// </summary>
public partial record Code : SecurityStatus3Choice_
{
    public required SecurityStatus2Code Value { get; init; }
}
