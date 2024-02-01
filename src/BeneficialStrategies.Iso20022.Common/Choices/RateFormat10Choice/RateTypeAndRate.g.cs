﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndRate.  ISO2002 ID# _hB24sCeJEeOXAt_43VmZGw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateFormat10Choice;

/// <summary>
/// Value is expressed as a rate type and a percentage rate.
/// </summary>
public partial record RateTypeAndRate : RateFormat10Choice_
{
    #nullable enable
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required RateType28Choice_ RateType { get; init; } 
    /// <summary>
    /// Value expressed as a rate.
    /// </summary>
    public required IsoPercentageRate Rate { get; init; } 
    #nullable disable
}
