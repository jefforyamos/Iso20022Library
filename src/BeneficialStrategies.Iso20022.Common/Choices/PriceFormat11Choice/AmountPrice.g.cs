﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountPrice.  ISO2002 ID# _Q4EOdtp-Ed-ak6NoX_4Aeg_-1893581153.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat11Choice;

/// <summary>
/// Price expressed as a currency and amount.
/// </summary>
public partial record AmountPrice : PriceFormat11Choice_
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
