﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Rofl09p-Ed-ak6NoX_4Aeg_227864528.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason20FormatChoice;

/// <summary>
/// Standard code to specify the reason of a rejection of the standing instruction request.
/// </summary>
public partial record Code : RejectionReason20FormatChoice_
{
    public required RejectionReason20Code Value { get; init; }
}
