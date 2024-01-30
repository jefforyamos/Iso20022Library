﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndAmountAndRateStatus.  ISO2002 ID# _-lv7SwVSEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat40Choice;

/// <summary>
/// Specifies different formats for the gross dividend rate.
/// </summary>
public partial record RateTypeAndAmountAndRateStatus : IGrossDividendRateFormat40Choice
{
    #nullable enable
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required IRateType82Choice RateType { get; init; } 
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    public IRateStatus4Choice? RateStatus { get; init; } 
    #nullable disable
}
