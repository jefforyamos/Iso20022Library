﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OnLoanBalance.  ISO2002 ID# _ujGeWcSTEeeRJJtE9TSlkw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionUnallocatedBalanceSD3Choice;

/// <summary>
/// Quantity of securities in the sub-balance.
/// </summary>
public partial record OnLoanBalance : ICorporateActionUnallocatedBalanceSD3Choice
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
