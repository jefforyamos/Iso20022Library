﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AddendumInitiation.  ISO2002 ID# _3PzOcBs6EeqrvK3udMUsNQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Addendum initiation message record.
/// </summary>
public partial record AddendumInitiation : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
