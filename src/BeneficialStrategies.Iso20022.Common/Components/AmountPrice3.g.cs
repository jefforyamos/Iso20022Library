﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountPrice3.  ISO2002 ID# _QaQ4J9p-Ed-ak6NoX_4Aeg_-1667090335.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price expressed as an amount.
/// </summary>
public partial record AmountPrice3
{
    #nullable enable
    
    /// <summary>
    /// Type of amount price.
    /// </summary>
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    /// <summary>
    /// Value of the price.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    
    #nullable disable
}
