﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _2e1tQTqHEeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BlockTrade4Choice;

/// <summary>
/// Block parent or child information expressed as an ISO 20022 code.
/// </summary>
public partial record Code : BlockTrade4Choice_
{
    public required BlockTrade1Code Value { get; init; }
}
