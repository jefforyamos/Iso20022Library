﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherPaymentTerms.  ISO2002 ID# _yg8O4NP8EeK0PPbKncCqzA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentCodeOrOther1Choice;

/// <summary>
/// Specifies payment terms not present in a code list.
/// </summary>
public partial record OtherPaymentTerms : IPaymentCodeOrOther1Choice
{
    public required IsoMax140Text Value { get; init; }
}
