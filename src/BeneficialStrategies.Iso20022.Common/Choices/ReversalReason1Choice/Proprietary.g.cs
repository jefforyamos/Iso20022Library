﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _TPTypdp-Ed-ak6NoX_4Aeg_673786832.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReversalReason1Choice;

/// <summary>
/// Reason for the reversal not catered for by the available codes.
/// </summary>
public partial record Proprietary : ReversalReason1Choice_
{
    public required IsoMax35Text Value { get; init; }
}
