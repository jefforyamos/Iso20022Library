﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AmountToQuantity.  ISO2002 ID# _7_6mv0EKEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SolicitationFeeRateFormat7Choice;

/// <summary>
/// Ratio expressed as an amount to quantity ratio.
/// </summary>
public partial record AmountToQuantity : SolicitationFeeRateFormat7Choice_
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
