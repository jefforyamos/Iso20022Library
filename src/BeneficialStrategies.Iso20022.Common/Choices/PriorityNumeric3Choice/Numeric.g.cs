﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Numeric.  ISO2002 ID# _AbWUsNokEeC60axPepSq7g_-1474945683.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriorityNumeric3Choice;

/// <summary>
/// Specifies the execution priority of the instruction with a number between 0001 and 9999.
/// </summary>
public partial record Numeric : PriorityNumeric3Choice_
{
    public required IsoExact4NumericText Value { get; init; }
}
