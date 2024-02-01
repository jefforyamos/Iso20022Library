﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndAmountAndRateStatus.  ISO2002 ID# _UOpIsdp-Ed-ak6NoX_4Aeg_1518191019.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat1Choice;

/// <summary>
/// Specifies different formats for the net dividend rate.
/// </summary>
public partial record RateTypeAndAmountAndRateStatus : NetDividendRateFormat1Choice_
{
    #nullable enable
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required RateType7Choice_ RateType { get; init; } 
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    public RateStatus1Choice_? RateStatus { get; init; } 
    #nullable disable
}
