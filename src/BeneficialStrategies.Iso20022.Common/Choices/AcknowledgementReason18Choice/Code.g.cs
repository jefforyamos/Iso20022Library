﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6BLh45NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AcknowledgementReason18Choice;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
public partial record Code : AcknowledgementReason18Choice_
{
    public required RepoCallAcknowledgementReason2Code Value { get; init; }
}
