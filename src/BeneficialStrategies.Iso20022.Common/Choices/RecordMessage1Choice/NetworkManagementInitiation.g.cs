﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NetworkManagementInitiation.  ISO2002 ID# _czvUcRs8EeqrvK3udMUsNQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice;

/// <summary>
/// Network management initiation message record.
/// </summary>
public partial record NetworkManagementInitiation : RecordMessage1Choice_
{
    public required IsoMax2MBBinary Value { get; init; }
}
