﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BankersDraft.  ISO2002 ID# _t7vvJRdHEeK5g-3oYI0_9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument17Choice;

/// <summary>
/// Indicates whether the payment is done via draft.
/// </summary>
public partial record BankersDraft : PaymentInstrument17Choice_
{
    public required IsoYesNoIndicator Value { get; init; }
}
