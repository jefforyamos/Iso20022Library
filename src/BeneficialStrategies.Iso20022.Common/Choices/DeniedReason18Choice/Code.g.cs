﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6BLiMZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeniedReason18Choice;

/// <summary>
/// Specifies additional information about the processed instruction.
/// </summary>
public partial record Code : DeniedReason18Choice_
{
    public required DeniedReason3Code Value { get; init; }
}
