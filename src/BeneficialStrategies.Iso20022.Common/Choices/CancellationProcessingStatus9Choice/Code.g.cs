﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _BxXzkeFfEeWIA4E9cYSxxQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationProcessingStatus9Choice;

/// <summary>
/// Provides the status of a cancellation request.
/// </summary>
public partial record Code : CancellationProcessingStatus9Choice_
{
    public required CancellationProcessingStatus3Code Value { get; init; }
}
