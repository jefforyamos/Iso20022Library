﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LongNumber.  ISO2002 ID# _celQ3ZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DocumentNumber6Choice;

/// <summary>
/// MX Message identifier of the referenced document.
/// </summary>
public partial record LongNumber : IDocumentNumber6Choice
{
    public required IsoISO20022MessageIdentificationText Value { get; init; }
}
