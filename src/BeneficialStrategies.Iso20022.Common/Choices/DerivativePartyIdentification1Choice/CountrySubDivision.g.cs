﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CountrySubDivision.  ISO2002 ID# _sN3rEEW8EeWaZZ6gWK8UVw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DerivativePartyIdentification1Choice;

/// <summary>
/// Country and country sub-division of the reference entity.
/// </summary>
public partial record CountrySubDivision : IDerivativePartyIdentification1Choice
{
    public required CountrySubDivisionCode Value { get; init; }
}
