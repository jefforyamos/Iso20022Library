﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QnhWUReoEeyroI8qKgB7Mg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat17Choice;

/// <summary>
/// Standard code to specify the additional business process linked to a corporate action event.
/// </summary>
public partial record Code : AdditionalBusinessProcessFormat17Choice_
{
    public required AdditionalBusinessProcess9Code Value { get; init; }
}
