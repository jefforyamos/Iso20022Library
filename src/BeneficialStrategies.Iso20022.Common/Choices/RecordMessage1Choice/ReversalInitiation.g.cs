﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ReversalInitiation.  ISO2002 ID# _f8HBMFZWEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Reversal initiation message record.
/// </summary>
public partial record ReversalInitiation : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
