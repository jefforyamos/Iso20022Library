﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _6PphwpqlEeGSON8vddiWzQ_-1045448850.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BillingSubServiceQualifier1Choice;

/// <summary>
/// Specifies the contents of the sub service qualifier, in a free-text form.
/// </summary>
public partial record Proprietary : IBillingSubServiceQualifier1Choice
{
    public required IsoMax35Text Value { get; init; }
}
