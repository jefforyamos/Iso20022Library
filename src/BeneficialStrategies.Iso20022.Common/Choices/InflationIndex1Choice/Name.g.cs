﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Name.  ISO2002 ID# _ZyZ21yS2EeWsI5Sp3-B3zg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InflationIndex1Choice;

/// <summary>
/// Standardised name of the index.
/// </summary>
public partial record Name : InflationIndex1Choice_
{
    public required IsoMax25Text Value { get; init; }
}
