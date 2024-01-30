﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FullPeriodUnits.  ISO2002 ID# _cjzu95KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat10Choice;

/// <summary>
/// Number of units of a fund that were purchased in a previous distribution period and/or held at the beginning of a distribution period, for example Group I Units in the UK.
/// </summary>
public partial record FullPeriodUnits : IBalanceFormat10Choice
{
    #nullable enable
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of security.
    /// </summary>
    public required IFinancialInstrumentQuantity15Choice Quantity { get; init; } 
    #nullable disable
}
