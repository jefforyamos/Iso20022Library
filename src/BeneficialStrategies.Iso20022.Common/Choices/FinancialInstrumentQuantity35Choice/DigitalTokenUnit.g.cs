﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DigitalTokenUnit.  ISO2002 ID# _vfexwRu1EeyhRdHRjakS2w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity35Choice;

/// <summary>
/// Quantity of digital tokens expressed as a number, for example, a number of blockchain tokens.
/// </summary>
public partial record DigitalTokenUnit : IFinancialInstrumentQuantity35Choice
{
    public required IsoMax30DecimalNumber Value { get; init; }
}
