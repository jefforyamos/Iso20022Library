﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralInBalance.  ISO2002 ID# _1QPnljL3EeKU9IrkkToqcw_1119803440.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionUnallocatedBalanceSD1Choice;

/// <summary>
/// Quantity of securities in the sub-balance.
/// </summary>
public partial record CollateralInBalance : ICorporateActionUnallocatedBalanceSD1Choice
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
