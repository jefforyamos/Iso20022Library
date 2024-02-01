﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TradeIdentification.  ISO2002 ID# _UTGx9tp-Ed-ak6NoX_4Aeg_1013873875.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References6Choice;

/// <summary>
/// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
/// </summary>
public partial record TradeIdentification : References6Choice_
{
    public required IsoMax35Text Value { get; init; }
}
