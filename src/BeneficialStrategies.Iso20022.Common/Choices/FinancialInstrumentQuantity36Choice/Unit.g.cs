﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unit.  ISO2002 ID# _peY04Ti7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity36Choice;

/// <summary>
/// Quantity expressed as a number, for example, a number of shares.
/// </summary>
public partial record Unit : IFinancialInstrumentQuantity36Choice
{
    public required IsoRestrictedFINDecimalNumber Value { get; init; }
}
