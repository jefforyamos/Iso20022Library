﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AlternativeInstrumentIdentification.  ISO2002 ID# _uVOw8wbSEeqrW7Meu5r3kQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.InstrumentIdentification1Choice;

/// <summary>
/// Proprietary identification of a security assigned by an institution or organisation.
/// </summary>
public partial record AlternativeInstrumentIdentification : IInstrumentIdentification1Choice
{
    public required IsoMax52Text Value { get; init; }
}
