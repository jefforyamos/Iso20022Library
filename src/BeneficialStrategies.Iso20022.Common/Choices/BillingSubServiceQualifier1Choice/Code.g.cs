﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6PphwZqlEeGSON8vddiWzQ_-1237515416.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BillingSubServiceQualifier1Choice;

/// <summary>
/// Specifies the contents of the sub service qualifier, in a coded form.
/// </summary>
public partial record Code : IBillingSubServiceQualifier1Choice
{
    public required BillingSubServiceQualifier1Code Value { get; init; }
}
