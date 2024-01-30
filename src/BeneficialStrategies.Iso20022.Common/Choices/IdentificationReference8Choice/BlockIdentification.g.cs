﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BlockIdentification.  ISO2002 ID# _AcPskNokEeC60axPepSq7g_-634475795.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference8Choice;

/// <summary>
/// Reference of the linked message at the trade/block level which identifies a centrally matched transaction.
/// </summary>
public partial record BlockIdentification : IIdentificationReference8Choice
{
    public required IsoMax35Text Value { get; init; }
}
