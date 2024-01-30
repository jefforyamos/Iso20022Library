﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice57.  ISO2002 ID# _KOQjd0EFEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies prices of a corporate action.
/// </summary>
public partial record CorporateActionPrice57
{
    #nullable enable
    
    /// <summary>
    /// Maximum or cap price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    public IPriceFormat44Choice? MaximumPrice { get; init; } 
    /// <summary>
    /// Minimum or floor price at which a holder can bid, for example, on a Dutch auction offer.
    /// </summary>
    public IPriceFormat44Choice? MinimumPrice { get; init; } 
    
    #nullable disable
}
