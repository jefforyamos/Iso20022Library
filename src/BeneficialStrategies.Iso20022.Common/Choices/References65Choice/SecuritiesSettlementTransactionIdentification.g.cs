﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesSettlementTransactionIdentification.  ISO2002 ID# _1IqiU9BwEeihG9bKfarOOA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References65Choice;

/// <summary>
/// Unambiguous identification of a securities settlement transaction as known by the account owner (or instructing party acting on its behalf).
/// </summary>
public partial record SecuritiesSettlementTransactionIdentification : References65Choice_
{
    public required IsoMax35Text Value { get; init; }
}
