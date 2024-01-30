﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountPrice4.  ISO2002 ID# _WiwgaNp-Ed-ak6NoX_4Aeg_-425450336.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price expressed as an actual amount.
/// </summary>
public partial record AmountPrice4
{
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    public required AmountPriceType2Code AmountPriceType { get; init; } 
    /// <summary>
    /// Value of the price.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    
    #nullable disable
}
