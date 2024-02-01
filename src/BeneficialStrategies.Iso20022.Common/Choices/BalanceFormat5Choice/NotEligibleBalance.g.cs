﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotEligibleBalance.  ISO2002 ID# _kvec4Tq5EeWQ1Y7f8kds2A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceFormat5Choice;

/// <summary>
/// Provide not eligible balance information in different formats.
/// </summary>
public partial record NotEligibleBalance : BalanceFormat5Choice_
{
    #nullable enable
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of security.
    /// </summary>
    public required FinancialInstrumentQuantity1Choice_ Quantity { get; init; } 
    #nullable disable
}
