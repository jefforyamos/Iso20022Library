﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToQuantity.  ISO2002 ID# _fflq7QgYEeCVlvYcV4HKqQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat14Choice;

/// <summary>
/// Ratio expressed as a quotient of quantities.
/// </summary>
public partial record QuantityToQuantity : IRatioFormat14Choice
{
    #nullable enable
    /// <summary>
    /// Numerator of the quotient of quantities.
    /// </summary>
    public required IsoRestrictedFINDecimalNumber Quantity1 { get; init; } 
    /// <summary>
    /// Denominator of the quotient of quantities.
    /// </summary>
    public required IsoRestrictedFINDecimalNumber Quantity2 { get; init; } 
    #nullable disable
}
