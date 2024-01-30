﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndAmountAndRateStatus.  ISO2002 ID# _PA8Q5WOXEeWYYI9c62RCjw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat22Choice;

/// <summary>
/// Specifies different formats for the net dividend rate.
/// </summary>
public partial record RateTypeAndAmountAndRateStatus : INetDividendRateFormat22Choice
{
    #nullable enable
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required IRateType39Choice RateType { get; init; } 
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    public IRateStatus3Choice? RateStatus { get; init; } 
    #nullable disable
}
