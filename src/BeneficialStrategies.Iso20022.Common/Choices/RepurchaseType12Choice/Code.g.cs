﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _YbpmcTqHEeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseType12Choice;

/// <summary>
/// Type of securities financing transaction process expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IRepurchaseType12Choice
{
    public required RepurchaseType3Code Value { get; init; }
}
