﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _WNdtg9uJEd-RF5yaMAVhAw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseType7Choice;

/// <summary>
/// Type of securities financing transaction process expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IRepurchaseType7Choice
{
    public required RepurchaseType5Code Value { get; init; }
}
