﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _iSz04TnvEeWfSKvvZlhRKg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason12Choice;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
public partial record Code : AcknowledgementReason12Choice_
{
    public required AcknowledgementReason5Code Value { get; init; }
}
