﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndAmountAndRateStatus.  ISO2002 ID# _UNAJ-Np-Ed-ak6NoX_4Aeg_-1557223642.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GrossDividendRateFormat2Choice;

/// <summary>
/// Specifies different formats for the gross dividend rate.
/// </summary>
public partial record RateTypeAndAmountAndRateStatus : GrossDividendRateFormat2Choice_
{
    #nullable enable
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required RateType13Choice_ RateType { get; init; } 
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
