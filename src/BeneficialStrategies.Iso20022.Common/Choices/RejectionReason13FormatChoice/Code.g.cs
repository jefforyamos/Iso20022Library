﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RoMq49p-Ed-ak6NoX_4Aeg_331296664.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason13FormatChoice;

/// <summary>
/// Standard code to specify the reason of a rejection of a movement.
/// </summary>
public partial record Code : IRejectionReason13FormatChoice
{
    public required RejectionReason13Code Value { get; init; }
}
