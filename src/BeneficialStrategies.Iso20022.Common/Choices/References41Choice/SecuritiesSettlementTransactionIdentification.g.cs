﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesSettlementTransactionIdentification.  ISO2002 ID# _QaEOhTnrEeWfSKvvZlhRKg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References41Choice;

/// <summary>
/// Unambiguous identification of a securities settlement transaction as known by the account owner (or instructing party acting on its behalf).
/// </summary>
public partial record SecuritiesSettlementTransactionIdentification : IReferences41Choice
{
    public required IsoMax35Text Value { get; init; }
}
