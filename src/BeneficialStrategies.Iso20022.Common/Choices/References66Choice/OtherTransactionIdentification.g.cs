﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherTransactionIdentification.  ISO2002 ID# _MMl9D_yjEeiM0vtizCHcoA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References66Choice;

/// <summary>
/// Identification of a transaction that cannot be identified using a standard reference element present in the message.
/// </summary>
public partial record OtherTransactionIdentification : IReferences66Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
