﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndAmountAndRateStatus.  ISO2002 ID# _fNdjQJSjEeeh5JjedkaA_g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat51Choice;

/// <summary>
/// Value is expressed as a rate type and an amount.
/// </summary>
public partial record RateTypeAndAmountAndRateStatus : IRateAndAmountFormat51Choice
{
    #nullable enable
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required IDeemedRateType1Choice RateType { get; init; } 
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
