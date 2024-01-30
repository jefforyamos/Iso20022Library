﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateTypeAndAmountAndStatus27.  ISO2002 ID# _Wf3Xu0EIEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value expressed as a rate and an amount.
/// </summary>
public partial record RateTypeAndAmountAndStatus27
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required IRateType37Choice RateType { get; init; } 
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
