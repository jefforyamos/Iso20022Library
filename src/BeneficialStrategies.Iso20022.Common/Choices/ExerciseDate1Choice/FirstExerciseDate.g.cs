﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FirstExerciseDate.  ISO2002 ID# _Y7c_sgbBEeqrW7Meu5r3kQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ExerciseDate1Choice;

/// <summary>
/// Specifies the earliest unadjusted date during the exercise period on which an option can be exercised.
/// ||Usage|: For European style options, the first possible exercise date is the same as the ExpirationDate.|
/// For American style options, the first possible exercise date is the same as the ExecutionTimeStamp.|
/// For Knock-in options, the first exercise date is reported when available.
/// </summary>
public partial record FirstExerciseDate : IExerciseDate1Choice
{
    public required IsoISODate Value { get; init; }
}
