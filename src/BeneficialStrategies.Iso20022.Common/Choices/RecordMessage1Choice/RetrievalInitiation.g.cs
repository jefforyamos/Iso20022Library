﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RetrievalInitiation.  ISO2002 ID# _nBmnwFZXEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Retrieval initiation message record.
/// </summary>
public partial record RetrievalInitiation : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
