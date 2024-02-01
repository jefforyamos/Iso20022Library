﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AllocationIdentification.  ISO2002 ID# _AcPskdokEeC60axPepSq7g_-256644124.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference8Choice;

/// <summary>
/// Reference of the linked message at the allocation level which identifies a centrally matched transaction.
/// </summary>
public partial record AllocationIdentification : IdentificationReference8Choice_
{
    public required IsoMax35Text Value { get; init; }
}
