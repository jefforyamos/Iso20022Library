﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PoolIdentification.  ISO2002 ID# _61RR_ZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References58Choice;

/// <summary>
/// Collective reference identifying a set of messages.
/// </summary>
public partial record PoolIdentification : References58Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
