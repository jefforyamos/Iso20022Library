﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountAndRateStatus.  ISO2002 ID# _k9oDFc3xEee5nJBZsW8MFQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.NetDividendRateFormat35Choice;

/// <summary>
/// Specifies an amount and a rate status.
/// </summary>
public partial record AmountAndRateStatus : INetDividendRateFormat35Choice
{
    #nullable enable
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    public required RateStatus1Code RateStatus { get; init; } 
    #nullable disable
}
