﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8Qc2bZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DeniedReason23Choice;

/// <summary>
/// Specifies the reason why the request was denied.
/// </summary>
public partial record Code : IDeniedReason23Choice
{
    public required DeniedReason7Code Value { get; init; }
}
