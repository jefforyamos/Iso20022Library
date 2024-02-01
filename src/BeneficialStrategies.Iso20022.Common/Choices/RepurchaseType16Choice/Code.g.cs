﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _5-A5VZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseType16Choice;

/// <summary>
/// Type of securities financing transaction process expressed as an ISO 20022 code.
/// </summary>
public partial record Code : RepurchaseType16Choice_
{
    public required RepurchaseType5Code Value { get; init; }
}
