﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ToDate.  ISO2002 ID# _76joYaMgEeCJ6YNENx4h-w_1338953670.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndPeriod2Choice;

/// <summary>
/// Date at which the range ends.
/// </summary>
public partial record ToDate : IDateAndPeriod2Choice
{
    public required IsoISODate Value { get; init; }
}
