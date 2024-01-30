﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RateTypeAndRate.  ISO2002 ID# _ACL0TUEJEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat41Choice;

/// <summary>
/// Value is expressed as a rate type and a percentage rate.
/// </summary>
public partial record RateTypeAndRate : IRateAndAmountFormat41Choice
{
    #nullable enable
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    public required IRateType42Choice RateType { get; init; } 
    /// <summary>
    /// Value expressed as a rate.
    /// </summary>
    public required IsoPercentageRate Rate { get; init; } 
    #nullable disable
}
