﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DateTime.  ISO2002 ID# _ctouQf1cEeiAfJEqh4xF_Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Period8Choice;

/// <summary>
/// Date and time period is limited to a single date.
/// </summary>
public partial record DateTime : Period8Choice_
{
    public required IsoISODateTime Value { get; init; }
}
