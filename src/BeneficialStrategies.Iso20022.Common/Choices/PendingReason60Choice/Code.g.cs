﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _qTHeYyAdEeuyDZ-ukt4YRg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason60Choice;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
public partial record Code : PendingReason60Choice_
{
    public required PendingReason21Code Value { get; init; }
}
