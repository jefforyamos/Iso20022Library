﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Dutch.  ISO2002 ID# _cH1L9TnxEeabspMEjqY5TQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice;

/// <summary>
/// Identifier for Dutch securities.
/// </summary>
public partial record Dutch : SecurityIdentification25Choice_
{
    public required IsoDutchIdentifier Value { get; init; }
}
