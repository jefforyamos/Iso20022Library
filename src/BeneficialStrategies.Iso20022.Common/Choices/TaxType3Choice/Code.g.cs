﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _NCW8gjh7EeaH-93K5JKmzw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TaxType3Choice;

/// <summary>
/// Type of tax expressed as a code.
/// </summary>
public partial record Code : ITaxType3Choice
{
    public required TaxType17Code Value { get; init; }
}
