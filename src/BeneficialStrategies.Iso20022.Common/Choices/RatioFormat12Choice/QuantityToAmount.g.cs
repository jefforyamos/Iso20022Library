﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityToAmount.  ISO2002 ID# _g3oehewOEd-sn-FiNtktcA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat12Choice;

/// <summary>
/// Ratio expressed as a quantity to amount ratio.
/// </summary>
public partial record QuantityToAmount : IRatioFormat12Choice
{
    #nullable enable
    /// <summary>
    /// Cash amount.
    /// </summary>
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    /// <summary>
    /// Quantity expressed as number.
    /// </summary>
    public required IsoDecimalNumber Quantity { get; init; } 
    #nullable disable
}
