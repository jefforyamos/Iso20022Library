﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BasketIdentificationAndEligibilitySetProfile1.  ISO2002 ID# _rh-hcLzTEeivTd4NUfCi2g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the baskets identification and the Eligibility Set Profile.
/// </summary>
public partial record BasketIdentificationAndEligibilitySetProfile1
{
    #nullable enable
    
    /// <summary>
    /// Number identifying the preferred collateral basket.
    /// </summary>
    public GenericIdentification1? PreferentialBasketIdentificationNumber { get; init; } 
    /// <summary>
    /// Number identifying the fallback starting collateral basket.
    /// </summary>
    public GenericIdentification1? FallbackStartingBasketIdentification { get; init; } 
    /// <summary>
    /// Number identifying the collateral basket to be excluded.
    /// </summary>
    public GenericIdentification1? ExclusionBasketIdentification { get; init; } 
    /// <summary>
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    public GenericIdentification1? EligibilitySetProfile { get; init; } 
    
    #nullable disable
}
