﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _d-eJIUEGEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConsentTypeFormat4Choice;

/// <summary>
/// Standard code to specify the consent type required.
/// </summary>
public partial record Code : IConsentTypeFormat4Choice
{
    public required ConsentType1Code Value { get; init; }
}
