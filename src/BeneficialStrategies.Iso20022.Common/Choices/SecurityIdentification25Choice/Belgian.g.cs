﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Belgian.  ISO2002 ID# _cH-V1TnxEeabspMEjqY5TQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification25Choice;

/// <summary>
/// Identifier for Belgian securities.
/// </summary>
public partial record Belgian : SecurityIdentification25Choice_
{
    public required IsoBelgianIdentifier Value { get; init; }
}
