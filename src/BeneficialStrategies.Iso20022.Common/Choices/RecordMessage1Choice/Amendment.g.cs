﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amendment.  ISO2002 ID# _JgxnIFZXEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Amendment message record.
/// </summary>
public partial record Amendment : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
