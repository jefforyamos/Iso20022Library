﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ReversalInitiation.  ISO2002 ID# _f8HBMFZWEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Reversal initiation message record.
/// </summary>
public partial record ReversalInitiation : RecordMessage1Choice_
{
    public required IsoMax2MBBinary Value { get; init; }
}
