﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountAndQuantityRatio5.  ISO2002 ID# _ckCYkpKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ratio expressed as amount per quantity.
/// </summary>
public partial record AmountAndQuantityRatio5
{
    #nullable enable
    
    /// <summary>
    /// Cash amount.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Quantity expressed as number.
    /// </summary>
    public required IsoRestrictedFINDecimalNumber Quantity { get; init; } 
    
    #nullable disable
}
