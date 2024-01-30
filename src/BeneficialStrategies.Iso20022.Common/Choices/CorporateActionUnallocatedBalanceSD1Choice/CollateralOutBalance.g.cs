﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralOutBalance.  ISO2002 ID# _1QYxgDL3EeKU9IrkkToqcw_122731087.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionUnallocatedBalanceSD1Choice;

/// <summary>
/// Quantity of securities in the sub-balance.
/// </summary>
public partial record CollateralOutBalance : ICorporateActionUnallocatedBalanceSD1Choice
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
