﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AddendumResponse.  ISO2002 ID# _6pwM0Rs6EeqrvK3udMUsNQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Addendum response message record.
/// </summary>
public partial record AddendumResponse : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
