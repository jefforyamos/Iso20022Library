﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for VerificationInitiation.  ISO2002 ID# _aHMxYFZYEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Verification initiation message record.
/// </summary>
public partial record VerificationInitiation : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
