﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KeyExchangeResponse.  ISO2002 ID# _QmhwsRs8EeqrvK3udMUsNQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Key exchange response message record.
/// </summary>
public partial record KeyExchangeResponse : IRecordMessage1Choice
{
    public required IsoMax2MBBinary Value { get; init; }
}
