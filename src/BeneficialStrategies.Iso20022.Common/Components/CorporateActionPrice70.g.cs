﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice70.  ISO2002 ID# _eQMS0e3LEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices related to a corporate action option.
/// </summary>
public partial record CorporateActionPrice70
{
    #nullable enable
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; } 
    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; init; } 
    /// <summary>
    /// Maximum cash amount that may be instructed.
    /// </summary>
    public PriceFormat61Choice_? MaximumCashToInstruct { get; init; } 
    /// <summary>
    /// Minimum cash amount that may be instructed.
    /// </summary>
    public PriceFormat61Choice_? MinimumCashToInstruct { get; init; } 
    /// <summary>
    /// Minimum multiple of a cash amount that may be instructed.
    /// </summary>
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; init; } 
    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    public PriceFormat44Choice_? MaximumPrice { get; init; } 
    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    public PriceFormat44Choice_? MinimumPrice { get; init; } 
    
    #nullable disable
}
