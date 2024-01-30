﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SecuritiesSettlementTransactionConfirmationIdentification.  ISO2002 ID# _USqtGNp-Ed-ak6NoX_4Aeg_-226304288.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References3Choice;

/// <summary>
/// Unambiguous identification of the confirmation to be cancelled.
/// </summary>
public partial record SecuritiesSettlementTransactionConfirmationIdentification : IReferences3Choice
{
    public required IsoMax35Text Value { get; init; }
}
