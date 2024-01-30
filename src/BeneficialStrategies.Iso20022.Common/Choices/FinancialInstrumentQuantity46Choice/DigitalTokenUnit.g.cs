﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DigitalTokenUnit.  ISO2002 ID# _DcYV6jT5Ee2j2eQlcOSMKg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity46Choice;

/// <summary>
/// Quantity of digital tokens expressed as a number, for example, a number of blockchain tokens.
/// </summary>
public partial record DigitalTokenUnit : IFinancialInstrumentQuantity46Choice
{
    public required IsoMax30DecimalNumber Value { get; init; }
}
