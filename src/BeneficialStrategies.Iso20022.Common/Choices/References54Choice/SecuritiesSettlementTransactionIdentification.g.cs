﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesSettlementTransactionIdentification.  ISO2002 ID# _6GW875NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References54Choice;

/// <summary>
/// Unambiguous identification of a securities settlement transaction as known by the account owner (or instructing party acting on its behalf).
/// </summary>
public partial record SecuritiesSettlementTransactionIdentification : References54Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}
