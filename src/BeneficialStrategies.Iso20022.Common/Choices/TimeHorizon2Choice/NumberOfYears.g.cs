﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NumberOfYears.  ISO2002 ID# _VLt3s7VOEeqkjqDuFVh1-A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TimeHorizon2Choice;

/// <summary>
/// Minimum recommended holding (RHP) period.
/// </summary>
public partial record NumberOfYears : ITimeHorizon2Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
