﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OverTheCounter.  ISO2002 ID# _WNmIstp-Ed-ak6NoX_4Aeg_-1162943025.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification3Choice;

/// <summary>
/// Place at which the Over-the-Counter (OTC) transaction is executed.
/// </summary>
public partial record OverTheCounter : IPlaceOfTradeIdentification3Choice
{
    public required IsoRestrictedFINMax30Text Value { get; init; }
}
