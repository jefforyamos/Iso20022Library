﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToQuantity.  ISO2002 ID# _7mLRB0EKEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat18Choice;

/// <summary>
/// Ratio expressed as a quotient of quantities.
/// </summary>
public partial record QuantityToQuantity : IRatioFormat18Choice
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
