﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _P3hA4TT5Ee2j2eQlcOSMKg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity46Choice;

/// <summary>
/// Quantity expressed as a code.
/// </summary>
public partial record Code : FinancialInstrumentQuantity46Choice_
{
    public required Quantity1Code Value { get; init; }
}
