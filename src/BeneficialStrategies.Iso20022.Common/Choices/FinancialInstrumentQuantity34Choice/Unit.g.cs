﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unit.  ISO2002 ID# _lhWKIxu0EeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity34Choice;

/// <summary>
/// Quantity expressed as a number, for example, a number of shares.
/// </summary>
public partial record Unit : IFinancialInstrumentQuantity34Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
