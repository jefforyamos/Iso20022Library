﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TotalEligibleBalance.  ISO2002 ID# _ujGeIcSTEeeRJJtE9TSlkw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionUnallocatedBalanceSD3Choice;

/// <summary>
/// Total quantity of financial instruments of the balance.
/// </summary>
public partial record TotalEligibleBalance : ICorporateActionUnallocatedBalanceSD3Choice
{
    #nullable enable
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    public required ShortLong1Code ShortLongPosition { get; init; } 
    /// <summary>
    /// Quantity of security.
    /// </summary>
    public required IFinancialInstrumentQuantity15Choice Quantity { get; init; } 
    #nullable disable
}
