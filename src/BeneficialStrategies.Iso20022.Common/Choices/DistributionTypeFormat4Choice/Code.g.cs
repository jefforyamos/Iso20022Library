﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _3uCH4SXXEeOFIcNWlDEvdQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DistributionTypeFormat4Choice;

/// <summary>
/// Standard code to specify whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
/// </summary>
public partial record Code : IDistributionTypeFormat4Choice
{
    public required DistributionType3Code Value { get; init; }
}
