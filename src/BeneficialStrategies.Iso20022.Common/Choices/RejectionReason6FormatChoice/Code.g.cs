﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Rofl1tp-Ed-ak6NoX_4Aeg_234326718.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason6FormatChoice;

/// <summary>
/// Standard code to specify the reason of a rejection of the notification advice.
/// </summary>
public partial record Code : RejectionReason6FormatChoice_
{
    public required RejectionReason6Code Value { get; init; }
}
