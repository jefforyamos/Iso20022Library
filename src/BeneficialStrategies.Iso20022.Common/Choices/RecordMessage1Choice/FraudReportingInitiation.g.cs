﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FraudReportingInitiation.  ISO2002 ID# _xyAZ0FZYEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Fraud reporting initiation message record.
/// </summary>
public partial record FraudReportingInitiation : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
