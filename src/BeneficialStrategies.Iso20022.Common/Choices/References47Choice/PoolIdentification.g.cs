﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PoolIdentification.  ISO2002 ID# _KLKpmzzbEeWeNtT0s2RbkQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References47Choice;

/// <summary>
/// Collective reference identifying a set of messages.
/// </summary>
public partial record PoolIdentification : References47Choice_
{
    public required IsoMax35Text Value { get; init; }
}
