﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateTypeAndAmountAndStatus15.  ISO2002 ID# _kDsK3RLnEeKJ5uSjVyVvug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the value expressed as a rate and an amount.
/// </summary>
public partial record RateTypeAndAmountAndStatus15
{
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required RateType22Choice_ RateType { get; init; } 
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
