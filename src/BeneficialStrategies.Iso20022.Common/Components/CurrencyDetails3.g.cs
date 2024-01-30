﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyDetails3.  ISO2002 ID# _k8F0MfayEeerBJ4shjAzSA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a currency.
/// </summary>
public partial record CurrencyDetails3
{
    #nullable enable
    
    /// <summary>
    /// Alpha currency code (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    public required ActiveCurrencyCode AlphaCode { get; init; } 
    /// <summary>
    /// Numeric currency code (ISO 4217, 3 numeric characters).
    /// </summary>
    public required IsoExact3NumericText NumericCode { get; init; } 
    /// <summary>
    /// Maximal number of digits after the decimal separator for the currency.
    /// </summary>
    public required IsoNumber Decimal { get; init; } 
    /// <summary>
    /// Full name of the currency.
    /// </summary>
    public IsoMax35Text? Name { get; init; } 
    
    #nullable disable
}
