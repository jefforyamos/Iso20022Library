﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ZfuusUGPEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalBusinessProcessFormat11Choice;

/// <summary>
/// Standard code to specify the additional business process "tax refund" linked to a corporate action event.
/// </summary>
public partial record Code : AdditionalBusinessProcessFormat11Choice_
{
    public required AdditionalBusinessProcess7Code Value { get; init; }
}
