﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _mG9jSxu1EeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity35Choice;

/// <summary>
/// Quantity expressed as a code.
/// </summary>
public partial record Code : IFinancialInstrumentQuantity35Choice
{
    public required Quantity5Code Value { get; init; }
}
