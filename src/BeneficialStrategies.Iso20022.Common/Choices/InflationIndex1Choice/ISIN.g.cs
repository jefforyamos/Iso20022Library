﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ISIN.  ISO2002 ID# _ZyZ21SS2EeWsI5Sp3-B3zg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InflationIndex1Choice;

/// <summary>
/// International Securities Identification Number (ISIN) of the inflation index.
/// </summary>
public partial record ISIN : InflationIndex1Choice_
{
    public required IsoISINOct2015Identifier Value { get; init; }
}
