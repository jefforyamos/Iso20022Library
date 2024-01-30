﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToQuantity.  ISO2002 ID# _Rj3kgNp-Ed-ak6NoX_4Aeg_-278779346.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat1Choice;

/// <summary>
/// The ratio is expressed as a quantity per another quantity.
/// </summary>
public partial record QuantityToQuantity : IRatioFormat1Choice
{
    #nullable enable
    /// <summary>
    /// Numerator of the quotient of quantities.
    /// </summary>
    public required IsoDecimalNumber Quantity1 { get; init; } 
    /// <summary>
    /// Denominator of the quotient of quantities.
    /// </summary>
    public required IsoDecimalNumber Quantity2 { get; init; } 
    #nullable disable
}
