﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QueryName.  ISO2002 ID# _gdi6QdcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderCriteria4Choice;

/// <summary>
/// Recalls the criteria (search and return criteria) defined in a preceding query.
/// </summary>
public partial record QueryName : StandingOrderCriteria4Choice_
{
    public required IsoMax35Text Value { get; init; }
}
