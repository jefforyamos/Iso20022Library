﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ChequeDetails.  ISO2002 ID# _MgQvYBdKEeK5g-3oYI0_9Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument16Choice;

/// <summary>
/// Settlement instructions for a payment by cheque.
/// </summary>
public partial record ChequeDetails : IPaymentInstrument16Choice
{
    #nullable enable
    /// <summary>
    /// Party to which a cheque is made payable.
    /// </summary>
    public required NameAndAddress5 PayeeIdentification { get; init; } 
    #nullable disable
}
