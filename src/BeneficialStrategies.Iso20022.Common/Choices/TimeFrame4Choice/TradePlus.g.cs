﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TradePlus.  ISO2002 ID# _UAew6tp-Ed-ak6NoX_4Aeg_1882783639.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TimeFrame4Choice;

/// <summary>
/// An agreed number of days after the Trade date (T) used to define standard timeframes e.g T+3 settlement period. ||Where = T is the date that the price is applied to a transaction.
/// </summary>
public partial record TradePlus : ITimeFrame4Choice
{
    public required IsoNumber Value { get; init; }
}
