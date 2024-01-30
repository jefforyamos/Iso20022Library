﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToQuantity.  ISO2002 ID# _Rj3khNp-Ed-ak6NoX_4Aeg_1125895682.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat2Choice;

/// <summary>
/// The ratio is expressed as a quantity per another quantity.
/// </summary>
public partial record QuantityToQuantity : IRatioFormat2Choice
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
