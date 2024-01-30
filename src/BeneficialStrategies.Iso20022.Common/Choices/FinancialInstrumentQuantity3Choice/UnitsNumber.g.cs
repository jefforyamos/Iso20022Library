﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UnitsNumber.  ISO2002 ID# _VOteoNp-Ed-ak6NoX_4Aeg_1922478109.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity3Choice;

/// <summary>
/// Quantity of investment fund units redeemed.
/// </summary>
public partial record UnitsNumber : IFinancialInstrumentQuantity3Choice
{
    #nullable enable
    /// <summary>
    /// Quantity expressed as a number, eg, a number of shares.
    /// </summary>
    public required IsoDecimalNumber Unit { get; init; } 
    #nullable disable
}
