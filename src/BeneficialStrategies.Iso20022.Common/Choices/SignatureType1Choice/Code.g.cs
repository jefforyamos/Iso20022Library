﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _rszToDoHEeabspMEjqY5TQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SignatureType1Choice;

/// <summary>
/// Signature type expressed as a code.
/// </summary>
public partial record Code : ISignatureType1Choice
{
    public required SignatureType2Code Value { get; init; }
}
