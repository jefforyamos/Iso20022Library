﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _5TJ-u5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Registration11Choice;

/// <summary>
/// Registration information expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IRegistration11Choice
{
    public required Registration1Code Value { get; init; }
}
