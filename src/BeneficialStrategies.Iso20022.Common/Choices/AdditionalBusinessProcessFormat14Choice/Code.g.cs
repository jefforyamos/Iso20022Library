﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _979urpqZEeWNO_b7eN4F_w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat14Choice;

/// <summary>
/// Standard code to specify the additional business process "tax refund" linked to a corporate action event.
/// </summary>
public partial record Code : IAdditionalBusinessProcessFormat14Choice
{
    public required AdditionalBusinessProcess7Code Value { get; init; }
}
