﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EligibleBalance.  ISO2002 ID# _cjzu55KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat10Choice;

/// <summary>
/// Provide eligible balance information in different formats.
/// </summary>
public partial record EligibleBalance : IBalanceFormat10Choice
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
