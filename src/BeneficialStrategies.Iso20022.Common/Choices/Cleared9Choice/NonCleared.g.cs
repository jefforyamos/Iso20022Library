﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NonCleared.  ISO2002 ID# _4paV45QPEeiok48Eh9lW9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cleared9Choice;

/// <summary>
/// Indicates that the contract has not been cleared.
/// </summary>
public partial record NonCleared : Cleared9Choice_
{
    public required NoReasonCode Value { get; init; }
}
