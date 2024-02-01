﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountAndRateStatus.  ISO2002 ID# _ShoBRZb9Eee8S7xwGG7Veg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat31Choice;

/// <summary>
/// Specifies an amount and a rate status.
/// </summary>
public partial record AmountAndRateStatus : NetDividendRateFormat31Choice_
{
    #nullable enable
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    public required RateStatus1Code RateStatus { get; init; } 
    #nullable disable
}
