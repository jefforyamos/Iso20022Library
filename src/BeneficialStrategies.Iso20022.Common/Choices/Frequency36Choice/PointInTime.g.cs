﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PointInTime.  ISO2002 ID# _6IxUQWk2Eeanu6HLe77Rkg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Frequency36Choice;

/// <summary>
/// Specifies a frequency in terms of an exact point in time or moment within a specified period type.
/// </summary>
public partial record PointInTime : IFrequency36Choice
{
    #nullable enable
    /// <summary>
    /// Period for which the number of instructions are to be created and processed.
    /// </summary>
    public required Frequency6Code Type { get; init; } 
    /// <summary>
    /// Further information on the exact point in time the event should take place.
    /// </summary>
    public required IsoExact2NumericText PointInTimeValue { get; init; } 
    #nullable disable
}
