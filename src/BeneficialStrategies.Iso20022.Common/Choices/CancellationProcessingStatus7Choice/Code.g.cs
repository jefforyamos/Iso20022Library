﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _3bJPkTqqEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancellationProcessingStatus7Choice;

/// <summary>
/// Provides the status of a cancellation request.
/// </summary>
public partial record Code : ICancellationProcessingStatus7Choice
{
    public required CancellationProcessingStatus1Code Value { get; init; }
}
