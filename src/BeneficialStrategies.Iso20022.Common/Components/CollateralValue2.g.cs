﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralValue2.  ISO2002 ID# _cLR5seLXEeWFtOV72FbX9w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details of the collateral reference data.
/// </summary>
public partial record CollateralValue2
{
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    public required IsoISINOct2015Identifier SecurityIdentification { get; init; } 
    /// <summary>
    /// Valuation date for the price.
    /// </summary>
    public required IsoISODate ValuationDate { get; init; } 
    /// <summary>
    /// Provides details of the currency of the valuation.
    /// </summary>
    public ActiveCurrencyCode? ValuationCurrency { get; init; } 
    /// <summary>
    /// Provides details of the price provided for the security.
    /// </summary>
    public required IAmountOrCoefficientPrice1Choice ValuationPrice { get; init; } 
    
    #nullable disable
}
