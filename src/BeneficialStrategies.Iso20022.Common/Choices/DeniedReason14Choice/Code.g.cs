﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _2WdbQTqxEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DeniedReason14Choice;

/// <summary>
/// Specifies the reason why the request was denied.
/// </summary>
public partial record Code : IDeniedReason14Choice
{
    public required DeniedReason7Code Value { get; init; }
}
