﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountAndRateStatus.  ISO2002 ID# _DVZBe-XsEemEj48jhmlA0Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat36Choice;

/// <summary>
/// Specifies an amount and a rate status.
/// </summary>
public partial record AmountAndRateStatus : IGrossDividendRateFormat36Choice
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
