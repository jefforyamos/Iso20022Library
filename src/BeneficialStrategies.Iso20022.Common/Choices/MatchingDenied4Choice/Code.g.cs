﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6GWWD5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingDenied4Choice;

/// <summary>
/// Specifies the execution of a matching denial process.
/// </summary>
public partial record Code : IMatchingDenied4Choice
{
    public required MatchingProcess1Code Value { get; init; }
}
