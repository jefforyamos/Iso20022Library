﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesSettlementTransactionIdentification.  ISO2002 ID# _61RR9ZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References58Choice;

/// <summary>
/// Unambiguous identification of a securities settlement transaction as known by the account owner (or instructing party acting on its behalf).
/// </summary>
public partial record SecuritiesSettlementTransactionIdentification : IReferences58Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
