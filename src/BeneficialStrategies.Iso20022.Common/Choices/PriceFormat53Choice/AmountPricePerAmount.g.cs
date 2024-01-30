﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountPricePerAmount.  ISO2002 ID# _che0k5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat53Choice;

/// <summary>
/// Price expressed as a ratio: amount price per amount.
/// </summary>
public partial record AmountPricePerAmount : IPriceFormat53Choice
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
    /// <summary>
    /// The amount on which the price is based.
    /// </summary>
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #nullable disable
}
