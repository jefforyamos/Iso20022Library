﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarginCallResponseIdentification.  ISO2002 ID# _d0qV4wLyEeutW5-TpeYJhA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Reference3Choice;

/// <summary>
/// Unique identifier of the margin call response.
/// </summary>
public partial record MarginCallResponseIdentification : IReference3Choice
{
    public required IsoMax35Text Value { get; init; }
}
