﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PaymentInstructionReference.  ISO2002 ID# _Rbhg0Np-Ed-ak6NoX_4Aeg_-1132471765.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification3Choice;

/// <summary>
/// Unique and unambiguous identifier for a payment instruction, as assigned by the clearing agent or the initiating party.
/// </summary>
public partial record PaymentInstructionReference : IPaymentIdentification3Choice
{
    public required IsoMax35Text Value { get; init; }
}
