﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _3QQL0Bc9EeK5g-3oYI0_9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OwnershipType1Choice;

/// <summary>
/// Ownership type expressed as a code.
/// </summary>
public partial record Code : OwnershipType1Choice_
{
    public required AccountOwnershipType3Code Value { get; init; }
}
