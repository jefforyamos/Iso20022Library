﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _TsubFF99Ee262vCSVgjImg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionReversalReason6Choice;

/// <summary>
/// Standard code to specify the reason for the reversal.
/// </summary>
public partial record Code : CorporateActionReversalReason6Choice_
{
    public required CorporateActionReversalReason2Code Value { get; init; }
}
