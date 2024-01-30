﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnitsNumber.  ISO2002 ID# _RhC6BNp-Ed-ak6NoX_4Aeg_1213138673.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity9Choice;

/// <summary>
/// Total quantity of units to be subscribed.
/// </summary>
public partial record UnitsNumber : IFinancialInstrumentQuantity9Choice
{
    #nullable enable
    /// <summary>
    /// Quantity expressed as a number, eg, a number of shares.
    /// </summary>
    public required IsoDecimalNumber Unit { get; init; } 
    #nullable disable
}
