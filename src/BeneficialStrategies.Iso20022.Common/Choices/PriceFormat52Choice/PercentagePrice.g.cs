﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PercentagePrice.  ISO2002 ID# _chez6ZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat52Choice;

/// <summary>
/// Price expressed as a percentage.
/// </summary>
public partial record PercentagePrice : PriceFormat52Choice_
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
