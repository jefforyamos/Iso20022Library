﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _GygiYSY3EeW_ZNn8gbfY7Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason15Choice;

/// <summary>
/// Rejected reason expressed as a code.
/// </summary>
public partial record Code : RejectedReason15Choice_
{
    public required TransferRejectedStatusReason2Code Value { get; init; }
}
