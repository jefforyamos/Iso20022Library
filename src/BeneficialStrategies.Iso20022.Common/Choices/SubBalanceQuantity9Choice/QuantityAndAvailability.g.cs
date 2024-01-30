﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QuantityAndAvailability.  ISO2002 ID# _ciAo7zi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SubBalanceQuantity9Choice;

/// <summary>
/// Quantity of securities in the sub-balance and whether the balance is available.
/// </summary>
public partial record QuantityAndAvailability : ISubBalanceQuantity9Choice
{
    #nullable enable
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    public required IFinancialInstrumentQuantity36Choice Quantity { get; init; } 
    /// <summary>
    /// Indicates whether the quantity of securities on the sub-balance is available.
    /// </summary>
    public required IsoYesNoIndicator AvailabilityIndicator { get; init; } 
    #nullable disable
}
