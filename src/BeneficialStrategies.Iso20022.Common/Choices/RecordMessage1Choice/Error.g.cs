﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Error.  ISO2002 ID# _Dd9wIFZXEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Error message record.
/// </summary>
public partial record Error : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
