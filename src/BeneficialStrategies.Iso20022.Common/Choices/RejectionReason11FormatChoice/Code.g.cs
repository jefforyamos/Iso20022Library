﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RoC55dp-Ed-ak6NoX_4Aeg_313748819.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason11FormatChoice;

/// <summary>
/// Standard code to specify the reason of a rejection of the notification cancellation request.
/// </summary>
public partial record Code : RejectionReason11FormatChoice_
{
    public required RejectionReason11Code Value { get; init; }
}
