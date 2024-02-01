﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndividualAllocationIdentification.  ISO2002 ID# _Adu6U9okEeC60axPepSq7g_159579292.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IdentificationReference11Choice;

/// <summary>
/// Reference of the linked message at the individual allocation level which identifies a centrally matched transaction.
/// </summary>
public partial record IndividualAllocationIdentification : IdentificationReference11Choice_
{
    public required IsoMax35Text Value { get; init; }
}
