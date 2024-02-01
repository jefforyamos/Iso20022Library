﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToQuantity.  ISO2002 ID# _Q2IUxtp-Ed-ak6NoX_4Aeg_1480805968.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat5Choice;

/// <summary>
/// Ratio expressed as a quotient of quantities.
/// </summary>
public partial record QuantityToQuantity : RatioFormat5Choice_
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
