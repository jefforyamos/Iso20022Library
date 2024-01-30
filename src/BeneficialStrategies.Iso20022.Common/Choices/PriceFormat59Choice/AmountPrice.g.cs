﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountPrice.  ISO2002 ID# _ctkvC5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat59Choice;

/// <summary>
/// Price expressed as a currency and amount.
/// </summary>
public partial record AmountPrice : IPriceFormat59Choice
{
    #nullable enable
    /// <summary>
    /// Type of amount price.
    /// </summary>
    public required AmountPriceType1Code AmountPriceType { get; init; } 
    /// <summary>
    /// Value of the price.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount PriceValue { get; init; } 
    #nullable disable
}
