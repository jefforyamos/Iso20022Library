﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PercentagePrice.  ISO2002 ID# _PSmh8xuyEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat66Choice;

/// <summary>
/// Price expressed as a percentage.
/// </summary>
public partial record PercentagePrice : IPriceFormat66Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the type of percentage price.
    /// </summary>
    public required PriceRateType3Code PercentagePriceType { get; init; } 
    /// <summary>
    /// Specifies the value of price.
    /// </summary>
    public required IsoPercentageRate PriceValue { get; init; } 
    #nullable disable
}
