﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _S2N7UStYEeyhipY4f42fZQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionOrRepairStatus44Choice;

/// <summary>
/// Indicates that there is no reason available or to report.
/// </summary>
public partial record NoSpecifiedReason : RejectionOrRepairStatus44Choice_
{
    public required NoReasonCode Value { get; init; }
}
