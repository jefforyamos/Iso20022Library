﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8QcPa5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReplacementProcessingStatus9Choice;

/// <summary>
/// Provides the processing status of the replacement request.
/// </summary>
public partial record Code : IReplacementProcessingStatus9Choice
{
    public required ReplacementProcessingStatus1Code Value { get; init; }
}
