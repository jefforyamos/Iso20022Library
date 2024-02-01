﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyReference2.  ISO2002 ID# _SpYh4AEcEeCQm6a_G2yO_w_1950817465.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the process of a currency exchange or conversion.
/// </summary>
public partial record CurrencyReference2
{
    #nullable enable
    
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    public required CurrencyCode TargetCurrency { get; init; } 
    /// <summary>
    /// Currency of the amount to be converted in a currency conversion.
    /// </summary>
    public required CurrencyCode SourceCurrency { get; init; } 
    /// <summary>
    /// The value of one currency expressed in relation to another currency. ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    public ExchangeRateInformation1[] ExchangeRateInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}
