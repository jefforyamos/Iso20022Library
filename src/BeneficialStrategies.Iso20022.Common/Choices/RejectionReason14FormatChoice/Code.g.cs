﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RoMq5tp-Ed-ak6NoX_4Aeg_345150396.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason14FormatChoice;

/// <summary>
/// Standard code to specify the reason of a rejection of a movement cancellation request.
/// </summary>
public partial record Code : RejectionReason14FormatChoice_
{
    public required RejectionReason14Code Value { get; init; }
}
