﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NonCleared.  ISO2002 ID# _HQfLo7Q0EemI67HK7aviyg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Cleared10Choice;

/// <summary>
/// Specifies that the contract has not been cleared.
/// </summary>
public partial record NonCleared : Cleared10Choice_
{
    public required NoReasonCode Value { get; init; }
}
