﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TransactionIdentification.  ISO2002 ID# _5uqG8QKxEe2rHs6fbn9-0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification7Choice;

/// <summary>
/// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference element.
/// </summary>
public partial record TransactionIdentification : IPaymentIdentification7Choice
{
    public required IsoMax35Text Value { get; init; }
}
