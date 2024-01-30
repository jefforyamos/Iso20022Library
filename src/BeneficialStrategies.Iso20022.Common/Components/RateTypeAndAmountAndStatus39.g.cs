﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateTypeAndAmountAndStatus39.  ISO2002 ID# __2jex5b7Eee8S7xwGG7Veg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value expressed as a rate and an amount.
/// </summary>
public partial record RateTypeAndAmountAndStatus39
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required IRateType69Choice RateType { get; init; } 
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
