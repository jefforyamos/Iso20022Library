﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LEI.  ISO2002 ID# _unMS4EW8EeWaZZ6gWK8UVw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DerivativePartyIdentification1Choice;

/// <summary>
/// Identification of the reference party through Legal entity identifier.
/// </summary>
public partial record LEI : IDerivativePartyIdentification1Choice
{
    public required IsoLEIIdentifier Value { get; init; }
}
