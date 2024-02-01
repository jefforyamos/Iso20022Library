﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DerivativeCommodity2.  ISO2002 ID# _e-bjmXvyEeanCNPcMT7sSg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the details of a commodity derivative.
/// </summary>
public partial record DerivativeCommodity2
{
    #nullable enable
    
    /// <summary>
    /// Commodity product attributes.
    /// </summary>
    public required AssetClassCommodity3Choice_ Product { get; init; } 
    /// <summary>
    /// Transaction type as specified by the trading venue.
    /// </summary>
    public AssetClassTransactionType1Code? TransactionType { get; init; } 
    /// <summary>
    /// Final price type as specified by the trading venue.
    /// </summary>
    public AssetPriceType1Code? FinalPriceType { get; init; } 
    
    #nullable disable
}
