﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _pPlzWQFIEeGhYJiRaPcH8g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity20Choice;

/// <summary>
/// Quantity expressed as a code.
/// </summary>
public partial record Code : IFinancialInstrumentQuantity20Choice
{
    public required Quantity5Code Value { get; init; }
}
