﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndAmountAndRateStatus.  ISO2002 ID# _cj9gH5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat25Choice;

/// <summary>
/// Specifies different formats for the net dividend rate.
/// </summary>
public partial record RateTypeAndAmountAndRateStatus : NetDividendRateFormat25Choice_
{
    #nullable enable
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required RateType44Choice_ RateType { get; init; } 
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    public RateStatus4Choice_? RateStatus { get; init; } 
    #nullable disable
}
