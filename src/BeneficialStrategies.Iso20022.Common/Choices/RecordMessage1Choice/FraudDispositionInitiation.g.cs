﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FraudDispositionInitiation.  ISO2002 ID# _DovK0FZZEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Fraud disposition initiation message record.
/// </summary>
public partial record FraudDispositionInitiation : RecordMessage1Choice_
{
    public required IsoMax2MBBinary Value { get; init; }
}
