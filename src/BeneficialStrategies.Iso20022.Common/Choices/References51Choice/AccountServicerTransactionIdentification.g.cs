﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountServicerTransactionIdentification.  ISO2002 ID# _5Qz09ZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References51Choice;

/// <summary>
/// Unambiguous identification of the transaction as known by the account servicer.
/// </summary>
public partial record AccountServicerTransactionIdentification : IReferences51Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
