﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _gsSfpYMEEeWhGPRU7TIQwQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationType43Choice;

/// <summary>
/// Type of identification is defined using a code.
/// </summary>
public partial record Code : IdentificationType43Choice_
{
    public required TypeOfIdentification2Code Value { get; init; }
}
