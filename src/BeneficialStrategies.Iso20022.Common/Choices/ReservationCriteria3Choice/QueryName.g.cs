﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for QueryName.  ISO2002 ID# _EBPJQ24-EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReservationCriteria3Choice;

/// <summary>
/// Recalls the criteria (search and return criteria) defined in a preceding query.
/// </summary>
public partial record QueryName : IReservationCriteria3Choice
{
    public required IsoMax35Text Value { get; init; }
}
