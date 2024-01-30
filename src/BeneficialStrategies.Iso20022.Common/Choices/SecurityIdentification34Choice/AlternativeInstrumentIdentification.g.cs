﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AlternativeInstrumentIdentification.  ISO2002 ID# _Zlr-ow1HEeqV4s5SpzR1dQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification34Choice;

/// <summary>
/// Proprietary identification of a security assigned by an institution or organisation.
/// </summary>
public partial record AlternativeInstrumentIdentification : ISecurityIdentification34Choice
{
    public required IsoMax52Text Value { get; init; }
}
