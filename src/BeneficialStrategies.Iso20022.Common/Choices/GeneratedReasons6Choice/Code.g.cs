﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6d7vV5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GeneratedReasons6Choice;

/// <summary>
/// Specifies the reason why the transaction was generated.
/// </summary>
public partial record Code : GeneratedReasons6Choice_
{
    public required GeneratedReason3Code Value { get; init; }
}
