﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QueryName.  ISO2002 ID# _i8ykQZlPEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StandingOrderCriteria2Choice;

/// <summary>
/// Recalls the criteria (search and return criteria) defined in a preceding query.
/// </summary>
public partial record QueryName : IStandingOrderCriteria2Choice
{
    public required IsoMax35Text Value { get; init; }
}
