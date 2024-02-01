﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndAmountAndRateStatus.  ISO2002 ID# _AjCKN5b8Eee8S7xwGG7Veg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat30Choice;

/// <summary>
/// Specifies different formats for the net dividend rate.
/// </summary>
public partial record RateTypeAndAmountAndRateStatus : NetDividendRateFormat30Choice_
{
    #nullable enable
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required RateType69Choice_ RateType { get; init; } 
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    public RateStatus3Choice_? RateStatus { get; init; } 
    #nullable disable
}
