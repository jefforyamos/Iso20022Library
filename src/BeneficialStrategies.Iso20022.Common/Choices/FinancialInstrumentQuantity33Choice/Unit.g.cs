﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unit.  ISO2002 ID# _HEcNsRuyEeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity33Choice;

/// <summary>
/// Quantity expressed as a number, for example, a number of shares.
/// </summary>
public partial record Unit : IFinancialInstrumentQuantity33Choice
{
    public required IsoDecimalNumber Value { get; init; }
}
