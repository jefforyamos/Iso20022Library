﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _V8nGZ9p-Ed-ak6NoX_4Aeg_-801418309.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReversalReason3Choice;

/// <summary>
/// Reason for the reversal not catered for by the available codes.
/// </summary>
public partial record Proprietary : ReversalReason3Choice_
{
    public required IsoRestrictedMS02MS03CodeText Value { get; init; }
}
