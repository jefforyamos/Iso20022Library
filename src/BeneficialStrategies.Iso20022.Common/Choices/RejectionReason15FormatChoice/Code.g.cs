﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RoV00dp-Ed-ak6NoX_4Aeg_356231670.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectionReason15FormatChoice;

/// <summary>
/// Standard code to specify the reason of a rejection of an information advice.
/// </summary>
public partial record Code : IRejectionReason15FormatChoice
{
    public required RejectionReason15Code Value { get; init; }
}
