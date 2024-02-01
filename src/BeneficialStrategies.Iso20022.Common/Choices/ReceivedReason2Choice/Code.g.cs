﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _2y5NyFj6EeOgwYxfAV02bg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReceivedReason2Choice;

/// <summary>
/// Reason for the received status expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ReceivedReason2Choice_
{
    public required ExternalReceivedReason1Code Value { get; init; }
}
