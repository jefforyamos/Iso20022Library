﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6Sbqe5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseType19Choice;

/// <summary>
/// Type of securities financing transaction process expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IRepurchaseType19Choice
{
    public required RepurchaseType3Code Value { get; init; }
}
