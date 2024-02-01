﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AlternativeInstrumentIdentification.  ISO2002 ID# _xzhRMyyGEe2xAdY9t5fB3g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstrumentIdentification6Choice;

/// <summary>
/// Proprietary identification of a security assigned by an institution or organisation.
/// </summary>
public partial record AlternativeInstrumentIdentification : InstrumentIdentification6Choice_
{
    public required IsoMax52Text Value { get; init; }
}
