﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _QbJo9Np-Ed-ak6NoX_4Aeg_-893638729.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PriceFormat4Choice;

/// <summary>
/// Price expressed as a rate, ie, percentage.
/// </summary>
public partial record Rate : IPriceFormat4Choice
{
    #nullable enable
    /// <summary>
    /// Type of rate, eg, yield.
    /// </summary>
    public required IPriceRateType3FormatChoice RateType { get; init; } 
    /// <summary>
    /// Price expressed as a rate, ie, percentage.
    /// </summary>
    public required IsoPercentageRate RateValue { get; init; } 
    #nullable disable
}
