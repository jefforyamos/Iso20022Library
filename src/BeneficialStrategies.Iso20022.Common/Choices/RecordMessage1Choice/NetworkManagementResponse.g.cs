﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NetworkManagementResponse.  ISO2002 ID# _mMMRkRs8EeqrvK3udMUsNQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Network management response message record.
/// </summary>
public partial record NetworkManagementResponse : RecordMessage1Choice_
{
    public required IsoMax2MBBinary Value { get; init; }
}
