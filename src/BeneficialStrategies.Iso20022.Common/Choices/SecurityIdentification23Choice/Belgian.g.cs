﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Belgian.  ISO2002 ID# _CSq4SyGQEeW7gKYhAMEFCw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification23Choice;

/// <summary>
/// Identifier for Belgian securities.
/// </summary>
public partial record Belgian : ISecurityIdentification23Choice
{
    public required IsoBelgianIdentifier Value { get; init; }
}
