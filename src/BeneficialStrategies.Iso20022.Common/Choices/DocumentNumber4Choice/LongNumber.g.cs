﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LongNumber.  ISO2002 ID# _Adb_YtokEeC60axPepSq7g_1008094262.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DocumentNumber4Choice;

/// <summary>
/// MX Message identifier of the referenced document.
/// </summary>
public partial record LongNumber : IDocumentNumber4Choice
{
    public required IsoISO20022MessageIdentificationText Value { get; init; }
}
