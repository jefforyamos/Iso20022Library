﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ExpectedMessageFunction.  ISO2002 ID# _htqcM12aEeekzJIz1JxYSQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ATMCommandParameters3Choice;

/// <summary>
/// Message to send for the send message command.
/// </summary>
public partial record ExpectedMessageFunction : IATMCommandParameters3Choice
{
    public required MessageFunction8Code Value { get; init; }
}
