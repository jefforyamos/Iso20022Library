﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cp37YeLxEeWOD7aAy2fAcA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LegalRestrictions5Choice;

/// <summary>
/// Legal restrictions expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ILegalRestrictions5Choice
{
    public required LegalRestrictions2Code Value { get; init; }
}
