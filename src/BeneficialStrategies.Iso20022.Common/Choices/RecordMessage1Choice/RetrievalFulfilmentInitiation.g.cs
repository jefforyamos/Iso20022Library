﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RetrievalFulfilmentInitiation.  ISO2002 ID# _Ai2cQRs9EeqrvK3udMUsNQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Retrieval fulfilment initiation message record.
/// </summary>
public partial record RetrievalFulfilmentInitiation : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
