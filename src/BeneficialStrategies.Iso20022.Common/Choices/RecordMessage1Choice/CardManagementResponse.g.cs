﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CardManagementResponse.  ISO2002 ID# _qIiuEFZYEeen1vB4iz5SyA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Card management response message record.
/// </summary>
public partial record CardManagementResponse : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
