﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _fW_fZOIxEeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CreditorEnrolmentStatusReason2Choice;

/// <summary>
/// Reason, as published in an external reason code list.
/// </summary>
public partial record Code : CreditorEnrolmentStatusReason2Choice_
{
    public required ExternalCreditorEnrolmentStatusReason1Code Value { get; init; }
}
