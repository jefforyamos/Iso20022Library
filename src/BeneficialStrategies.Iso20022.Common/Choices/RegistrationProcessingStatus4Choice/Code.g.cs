﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8QcPI5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RegistrationProcessingStatus4Choice;

/// <summary>
/// Provides the status of the registration processing.
/// </summary>
public partial record Code : IRegistrationProcessingStatus4Choice
{
    public required RegistrationProcessingStatus1Code Value { get; init; }
}
