﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unstructured.  ISO2002 ID# _Q6vvB9p-Ed-ak6NoX_4Aeg_-2132356031.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DataFormat2Choice;

/// <summary>
/// Specification of data for which there isn't a structured form.
/// </summary>
public partial record Unstructured : IDataFormat2Choice
{
    public required IsoMax140Text Value { get; init; }
}
