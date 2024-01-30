﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnitPrice.  ISO2002 ID# _VMB-Ctp-Ed-ak6NoX_4Aeg_1790266847.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountPrice1Choice;

/// <summary>
/// Amount expressed as a unit price.
/// </summary>
public partial record UnitPrice : IAmountPrice1Choice
{
    #nullable enable
    /// <summary>
    /// Type and information about a price.
    /// </summary>
    public required TypeOfPrice8Code Type { get; init; } 
    /// <summary>
    /// Value of the price, eg, as a currency and value.
    /// </summary>
    public required PriceValue1 Value { get; init; } 
    #nullable disable
}
