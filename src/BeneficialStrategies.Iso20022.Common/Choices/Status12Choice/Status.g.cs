﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Status.  ISO2002 ID# _huaOeBdSEeK5g-3oYI0_9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status12Choice;

/// <summary>
/// Status of the account opening instruction or account modification instruction.
/// </summary>
public partial record Status : Status12Choice_
{
    public required AccountManagementStatus1Code Value { get; init; }
}
