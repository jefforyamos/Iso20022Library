﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _oTF3kEW8EeWaZZ6gWK8UVw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DerivativePartyIdentification1Choice;

/// <summary>
/// Country of the reference entity.
/// </summary>
public partial record Country : IDerivativePartyIdentification1Choice
{
    public required CountryCode Value { get; init; }
}
